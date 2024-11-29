using LeadTrack.Domain.interfaces;
using LeadTrack.Domain.models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LeadTrack.Services.services
{
    public class LeadService
    {
        private const string Message = "Lead not found.";
        private readonly ILeadRepository _leadRepository;
        private readonly FileService _fileService;
        public LeadService(ILeadRepository leadRepository, FileService fileService)
        {
            _leadRepository = leadRepository;
            _fileService = fileService;
        }

        public List<Lead> GetAll()
        {
            return _leadRepository.GetLeads().ToList();
        }

        public void UpdateLead(int id, StatusEnum status)
        {
            const decimal discount = 0.9m;
            const decimal valueFiveHundred = 500.00m;

            var lead = _leadRepository.GetLeads().FirstOrDefault(x => x.Id == id) ?? throw new Exception(Message);
            lead.Status = status;

            if (status == StatusEnum.Accepted && lead.Price > valueFiveHundred)
            {
                lead.Price *= discount;
            }

            _leadRepository.UpdateLead(id, status);
        }

        public byte[] GenerateLeadFile(int id)
        {
            var lead = _leadRepository.GetLeads().FirstOrDefault(x => x.Id == id);

            return lead == null ? throw new Exception(Message) : _fileService.GenerateLeadFileContent(lead);
        }
    }
}
