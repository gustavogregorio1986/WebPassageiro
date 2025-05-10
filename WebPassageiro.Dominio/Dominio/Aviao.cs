using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebPassageiro.Dominio.Dominio
{
    public class Aviao
    {
        public Guid Id { get; set; }

        public string? Companhia { get; set; }

        public string? Poltrona { get; set; }

        public string? Portao { get; set; }

        public string? Origem { get; set; }

        public string? Destino { get; set; }

        public int Status { get; set; }

        public Guid passageiroId { get; set; }

        public Passageiro? Passageiro { get; set; }
    }
}
