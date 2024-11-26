namespace estacionamento.Models
{
    public class Vaga
    {
        public required int Id { get; set; }

        public string? Localizacao { get; set; }

        public bool Ocupada { get; set; }
    }
}
