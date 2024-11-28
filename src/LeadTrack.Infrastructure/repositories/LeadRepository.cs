using LeadTrack.Domain.interfaces;
using LeadTrack.Domain.models;
using LeadTrack.Infrastructure.dataBase;

namespace LeadTrack.Infrastructure.repositories
{
    public class LeadRepository : ILeadRepository
    {
        private readonly LeadTrackContext _context;
        public LeadRepository(LeadTrackContext context)
        {
            _context = context;
        }

        public List<Lead> GetLeads()
        {
            return _context.Leads.ToList();
        }

        public void UpdateLead(int id, StatusEnum status)
        {
            var lead = _context.Leads.Find(id);
            if (lead != null)
            {
                lead.Status = status;
                _context.SaveChanges();
            }
        }
    }
}
