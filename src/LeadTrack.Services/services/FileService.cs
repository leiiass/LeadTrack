using LeadTrack.Domain.models;
using System.Text;
using System;

namespace LeadTrack.Services.services
{
    public class FileService
    {
        public byte[] GenerateLeadFileContent(Lead lead)
        {
            const string Message = "Lead cannot be null.";
            if (lead == null)
            {
                throw new ArgumentNullException(nameof(lead), Message);
            }

            string fileContent = $"Lead {lead.ContactFirstName} foi aceito.\n" +
                                 $"Preço atualizado: {lead.Price:C}.\n" +
                                 $"Categoria: {lead.Category}\n" +
                                 $"Subúrbio: {lead.Suburb}";

            return Encoding.UTF8.GetBytes(fileContent);
        }
    }
}
