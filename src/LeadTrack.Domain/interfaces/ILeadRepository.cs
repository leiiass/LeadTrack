using LeadTrack.Domain.models;
using System.Collections.Generic;

namespace LeadTrack.Domain.interfaces
{
    public interface ILeadRepository
    {
        void UpdateLead(int id, StatusEnum status);
        List<Lead> GetLeads();
    }
}