using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebPassageiro.Data.Context;
using WebPassageiro.Data.Repository.Interface;
using WebPassageiro.Dominio.Dominio;
using WebPassageiro.Service.Service.Interface;

namespace WebPassageiro.Service.Service
{
    public class AviaoService : IAviaoService
    {
        private readonly IAviaoRepository _aviaoRepository;

        public AviaoService(IAviaoRepository aviaoRepository)
        {
            _aviaoRepository = aviaoRepository;
        }

        public void AdicionarAviao(Aviao aviao)
        {
            _aviaoRepository.AdicionarAviao(aviao);
        }
    }
}
