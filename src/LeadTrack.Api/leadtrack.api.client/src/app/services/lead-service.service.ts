import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Lead, StatusEnum } from '../models/lead.model';

@Injectable({
  providedIn: 'root'
})
export class LeadServiceService {

  private apiUrl = 'https://localhost:7108/api/Lead';
  constructor(private http: HttpClient) { }

  getLeads(): Observable<Lead[]> {
    return this.http.get<Lead[]>(this.apiUrl);
  }

  updateLead(id: number, status: StatusEnum): Observable<void> {
    const headers = { 'Content-Type': 'application/json' };
    return this.http.patch<void>(`${this.apiUrl}/${id}`, JSON.stringify(status), { headers });
  }
  
  downloadLeadFile(id: number): Observable<Blob> {
    return this.http.get(`${this.apiUrl}/${id}/download`, { responseType: 'blob' });
  }
}
