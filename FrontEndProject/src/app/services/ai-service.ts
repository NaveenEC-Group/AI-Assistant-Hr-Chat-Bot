import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class AiService {
  constructor(private http: HttpClient) {}

  ask(question: string): Observable<string> {
    return this.http.post('/api/ai/ask', JSON.stringify(question), {
      headers: { 'Content-Type': 'application/json' },
      responseType: 'text',
    });
  }

  uploadDocument(file: File): Observable<{ added: number; message: string }> {
    const formData = new FormData();
    formData.append('file', file, file.name);
    return this.http.post<{ added: number; message: string }>('/api/ai/upload', formData);
  }
}
