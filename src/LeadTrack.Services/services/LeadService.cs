using LeadTrack.Domain.interfaces;
using LeadTrack.Domain.models;
using System.Collections.Generic;
using System.Linq;

namespace LeadTrack.Services.services
{
    public class LeadService
    {
        private readonly ILeadRepository _leadRepository;
        public LeadService(ILeadRepository leadRepository)
        {
           _leadRepository = leadRepository;
        }

        public List<Lead> GetAll()
        {
            return _leadRepository.GetLeads().ToList();
        }

        public void UpdateLead(string id, StatusEnum status)
        {
            //Logica de aplicar o desconto Se o preço for superior a US $ 500, será necessário aplicar 10 % de desconto ao preço.
            //Logica de enviar uma notificação por e-mail para vendas(vendas@test.com) observe que você não precisa enviar o e - mail real, você pode criar um serviço de e - mail falso que não faz nada ou simplesmente criar um arquivo de texto
        }
    }
}
