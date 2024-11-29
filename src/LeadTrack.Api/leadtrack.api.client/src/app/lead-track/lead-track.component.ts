import { Component, OnInit } from '@angular/core';
import { LeadServiceService } from '../services/lead-service.service';
import { Lead, StatusEnum } from '../models/lead.model';

@Component({
  selector: 'app-lead-track',
  templateUrl: './lead-track.component.html',
  styleUrl: './lead-track.component.css'
})
export class LeadTrackComponent implements OnInit {
  leads: Lead[] = [];
  invitedLeads: Lead[] = [];
  acceptedLeads: Lead[] = [];
  declinedLeads: Lead[] = [];

  constructor(private leadService: LeadServiceService) { }

  ngOnInit(): void {
    this.loadLeads();
  }

  loadLeads(): void {
    const invited = 0;
    const accepted = 1;
    const declined = 2;
    this.leadService.getLeads().subscribe({
      next: (data) => {
        this.leads = data;
        this.invitedLeads = this.leads.filter(lead => lead.status === invited);
        this.acceptedLeads = this.leads.filter(lead => lead.status === accepted);
        this.declinedLeads = this.leads.filter(lead => lead.status === declined);
      },
      error: (err) => {
        const messageError = 'Erro ao buscar leads:';
        console.error(messageError, err);
      }
    });
  }

  updateLeadStatus(leadId: number, status: StatusEnum): void {
    this.leadService.updateLead(leadId, status).subscribe({
      next: () => {
        const lead = this.invitedLeads.find(x => x.id === leadId);
        if (lead) {
          lead.status = status;
  
          this.invitedLeads = this.invitedLeads.filter(x => x.id !== leadId);
  
          if (status === StatusEnum.Accepted) {
            this.acceptedLeads.push(lead);
          } else if (status === StatusEnum.Declined) {
            this.declinedLeads.push(lead);
          }
        }
      },
      error: (err) => {
        const messageError = 'Erro ao atualizar o lead:';
        console.error(messageError, err);
      }
    });
  }

  downloadLeadFile(leadId: number): void {
    this.leadService.downloadLeadFile(leadId).subscribe({
      next: (blob: Blob) => {
        const url = window.URL.createObjectURL(blob);
        const a = document.createElement('a');
        a.href = url;
        a.download = `Lead_${leadId}_Accepted.txt`;
        document.body.appendChild(a);
        a.click();
        document.body.removeChild(a);
        window.URL.revokeObjectURL(url);
      },
      error: (err) => {
        const messageError = 'Erro ao fazer download do arquivo:';
        console.error(messageError, err);
      }
    });
  }
  
  onClickingAccept(leadId: number): void {
    this.updateLeadStatus(leadId, StatusEnum.Accepted);
    this.downloadLeadFile(leadId);
  }

  onClickingDecline(leadId: number): void {
    this.updateLeadStatus(leadId, StatusEnum.Declined);
  }
  
}
