using System.ComponentModel.DataAnnotations.Schema;

namespace estacionamento.Models
{
    [Table("veiculos")]

    public class Veiculo
    {
        public required int Id { get; set; }
        public string? Placa { get; set; }
        public string? Modelo { get; set; }
        public string? Marca { get; set; }
        public int ClienteId { get; set; }

    }
}
