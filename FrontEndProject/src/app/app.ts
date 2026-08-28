import { Component, ViewChild, signal } from '@angular/core';
import { Chat } from './Chat/chat/chat';

@Component({
  selector: 'app-root',
  templateUrl: './app.html',
  standalone: false,
  styleUrl: './app.css'
})
export class App {
  protected readonly title = signal('FrontEndProject');

  @ViewChild(Chat) private chat?: Chat;

  goHome(): void {
    this.chat?.goHome();
  }
}
