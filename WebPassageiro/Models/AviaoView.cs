namespace WebPassageiro.Models
{
    public class AviaoView
    {
        public Guid Id { get; set; }

        public string? Companhia { get; set; }

        public string? Poltrona { get; set; }

        public string? Portao { get; set; }

        public string? Origem { get; set; }

        public string? Destino { get; set; }

        public int Status { get; set; }

        public Guid passageiroId { get; set; }

        public PassageiroView? PassageiroView { get; set; }
    }
}
