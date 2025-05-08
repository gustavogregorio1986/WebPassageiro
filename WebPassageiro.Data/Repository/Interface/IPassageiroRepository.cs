using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebPassageiro.Dominio.Dominio;

namespace WebPassageiro.Data.Repository.Interface
{
    public interface IPassageiroRepository
    {
        void AdicionarPassageiro(Passageiro passageiro);
    }
}
