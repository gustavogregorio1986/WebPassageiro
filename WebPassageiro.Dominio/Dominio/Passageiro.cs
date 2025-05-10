using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebPassageiro.Dominio.Dominio
{
    public class Passageiro
    {
        public Guid Id { get; set; }

        public string? NomePassageiro { get; set; }

        public string? Cpf { get; set; }

        public string? Cidade { get; set; }

        public int Status { get; set; }


        public Aviao? Aviao { get; set; }
    }
}
