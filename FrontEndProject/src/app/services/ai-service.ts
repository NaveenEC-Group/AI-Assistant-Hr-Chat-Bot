import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { catchError } from 'rxjs/operators';

@Injectable({
  providedIn: 'root',
})
export class AiService {
  private readonly renderApiUrl = 'https://ai-assistant-hr-chat-bot.onrender.com/api/ai';

  constructor(private http: HttpClient) {}

  /** On Vercel, call Render directly (avoids Vercel proxy 502 timeouts). Locally use ng proxy. */
  private get apiUrl(): string {
    if (typeof window !== 'undefined' && /vercel\.app$/i.test(window.location.hostname)) {
      return this.renderApiUrl;
    }
    return '/api/ai';
  }

  /** Wake Render + build embedding index while the user is still typing. */
  warmup(): Observable<{ ready: boolean }> {
    return this.http
      .get<{ ready: boolean }>(`${this.apiUrl}/warmup`)
      .pipe(catchError(() => of({ ready: false })));
  }

  ask(question: string): Observable<string> {
    return this.http.post(`${this.apiUrl}/ask`, JSON.stringify(question), {
      headers: { 'Content-Type': 'application/json' },
      responseType: 'text',
    });
  }

  uploadDocument(file: File): Observable<{ added: number; message: string }> {
    const formData = new FormData();
    formData.append('file', file, file.name);

    return this.http.post<{ added: number; message: string }>(`${this.apiUrl}/upload`, formData);
  }
}
