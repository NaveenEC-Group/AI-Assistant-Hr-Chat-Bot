import { Component, ElementRef, ViewChild, AfterViewChecked, OnInit, NgZone, OnDestroy } from '@angular/core';
import { AiService } from '../../services/ai-service';

export interface ChatMessage {
  role: 'user' | 'ai';
  text: string;
  timestamp: Date;
  imageUrl?: string;
}

@Component({
  selector: 'app-chat',
  standalone: false,
  templateUrl: './chat.html',
  styleUrl: './chat.css',
})
export class Chat implements OnInit, AfterViewChecked, OnDestroy {
  question = '';
  loading = false;
  messages: ChatMessage[] = [];

  listening = false;
  speechSupported = false;

  uploading = false;

  private readonly friendImage = 'assets/velmurugan.png';
  private readonly naveenImage = 'assets/naveen.jpg';

  @ViewChild('scrollContainer') private scrollContainer!: ElementRef<HTMLElement>;
  private shouldScroll = false;

  private recognition: any = null;
  private baseTranscript = '';

  constructor(private aiService: AiService, private zone: NgZone) {
    this.initSpeechRecognition();
  }

  ngOnInit(): void {
    // Wake Render + pre-build vectors while the user reads the page / types.
    this.aiService.warmup().subscribe();
  }

  ngAfterViewChecked(): void {
    if (this.shouldScroll) {
      this.scrollToBottom();
      this.shouldScroll = false;
    }
  }

  ngOnDestroy(): void {
    if (this.recognition) {
      try {
        this.recognition.onresult = null;
        this.recognition.onerror = null;
        this.recognition.onend = null;
        this.recognition.stop();
      } catch {
        /* ignore */
      }
    }
  }

  private initSpeechRecognition(): void {
    const SpeechRecognitionImpl =
      (window as any).SpeechRecognition || (window as any).webkitSpeechRecognition;

    if (!SpeechRecognitionImpl) {
      this.speechSupported = false;
      return;
    }

    this.speechSupported = true;
    const recognition = new SpeechRecognitionImpl();
    recognition.lang = 'en-US';
    recognition.continuous = true;
    recognition.interimResults = true;

    recognition.onresult = (event: any) => {
      let finalText = '';
      let interimText = '';
      for (let i = event.resultIndex; i < event.results.length; i++) {
        const transcript = event.results[i][0].transcript;
        if (event.results[i].isFinal) {
          finalText += transcript;
        } else {
          interimText += transcript;
        }
      }
      if (finalText) {
        this.baseTranscript = (this.baseTranscript + ' ' + finalText).trim();
      }
      const combined = (this.baseTranscript + ' ' + interimText).trim();
      this.zone.run(() => {
        this.question = combined;
      });
    };

    recognition.onerror = () => {
      this.zone.run(() => {
        this.listening = false;
      });
    };

    recognition.onend = () => {
      this.zone.run(() => {
        this.listening = false;
      });
    };

    this.recognition = recognition;
  }

  toggleListening(): void {
    if (!this.speechSupported || !this.recognition || this.loading) return;

    if (this.listening) {
      this.recognition.stop();
      this.listening = false;
      return;
    }

    this.baseTranscript = this.question.trim();
    try {
      this.recognition.start();
      this.listening = true;
    } catch {
      this.listening = false;
    }
  }

  ask(): void {
    const q = this.question.trim();
    if (!q || this.loading) return;

    if (this.listening && this.recognition) {
      this.recognition.stop();
      this.listening = false;
    }

    this.messages.push({ role: 'user', text: q, timestamp: new Date() });
    this.question = '';
    this.loading = true;
    this.shouldScroll = true;

    this.aiService.ask(q).subscribe({
      next: (res) => {
        const aiMessage: ChatMessage = { role: 'ai', text: res, timestamp: new Date() };
        aiMessage.imageUrl = this.pickImage(q, res);
        this.messages.push(aiMessage);
        this.loading = false;
        this.shouldScroll = true;
      },
      error: (err) => {
        this.messages.push({
          role: 'ai',
          text: this.formatHttpError(err),
          timestamp: new Date(),
        });
        this.loading = false;
        this.shouldScroll = true;
      },
    });
  }

  private formatHttpError(err: any): string {
    const body = err?.error;
    if (typeof body === 'string' && body.trim()) return body;
    if (body && typeof body === 'object' && !(body instanceof ProgressEvent)) {
      if (typeof body.message === 'string') return body.message;
      try {
        return JSON.stringify(body);
      } catch {
        /* ignore */
      }
    }
    if (err?.status === 0) {
      return 'Could not reach the API. Check that the server is running (Render may take ~30s to wake).';
    }
    if (typeof err?.message === 'string' && err.message.trim()) return err.message;
    return 'Something went wrong. Please try again.';
  }

  private pickImage(question: string, answer: string): string | undefined {
    if (/\bfriend\b|velmurugan/i.test(question)) {
      return this.friendImage;
    }
    if (/naveen/i.test(question)) {
      return this.naveenImage;
    }
    if (/velmurugan/i.test(answer)) {
      return this.friendImage;
    }
    if (/naveen/i.test(answer)) {
      return this.naveenImage;
    }
    return undefined;
  }

  onImageError(msg: ChatMessage): void {
    msg.imageUrl = undefined;
  }

  onFileSelected(event: Event): void {
    const input = event.target as HTMLInputElement;
    const file = input.files?.[0];
    if (!file) return;

    const name = file.name.toLowerCase();
    if (!name.endsWith('.txt') && !name.endsWith('.md') && !name.endsWith('.pdf')) {
      this.messages.push({
        role: 'ai',
        text: 'Only .txt, .md, and .pdf files can be uploaded.',
        timestamp: new Date(),
      });
      this.shouldScroll = true;
      input.value = '';
      return;
    }

    this.uploading = true;
    this.shouldScroll = true;

    this.aiService.uploadDocument(file).subscribe({
      next: (res) => {
        this.messages.push({
          role: 'ai',
          text: `📄 "${file.name}" uploaded. ${res.message}`,
          timestamp: new Date(),
        });
        this.uploading = false;
        this.shouldScroll = true;
      },
      error: (err) => {
        this.messages.push({
          role: 'ai',
          text: this.formatHttpError(err),
          timestamp: new Date(),
        });
        this.uploading = false;
        this.shouldScroll = true;
      },
    });

    input.value = '';
  }

  private scrollToBottom(): void {
    const el = this.scrollContainer?.nativeElement;
    if (el) {
      el.scrollTop = el.scrollHeight;
    }
  }
}
