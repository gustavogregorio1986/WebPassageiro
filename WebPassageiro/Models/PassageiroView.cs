using WebPassageiro.Dominio.Dominio;

namespace WebPassageiro.Models
{
    public class PassageiroView
    {
        public Guid Id { get; set; }

        public string? NomePassageiro { get; set; }

        public string? Cpf { get; set; }

        public string? Cidade { get; set; }

        public int Status { get; set; }

        public AviaoView? AviaoView { get; set; }
    }
}
