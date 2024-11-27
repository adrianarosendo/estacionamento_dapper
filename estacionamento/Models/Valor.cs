using System.ComponentModel.DataAnnotations.Schema;

namespace estacionamento.Models
{
    [Table("valores")]

    public class ValorCobrado
    {
        public required int Id { get; set; }
        public float Minuto { get; set; }
        public float Valor { get; set; }
    }
}
