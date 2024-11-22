namespace ui.Models
{
    public class Ticket
    {
        public required int Id { get; set; }
        public DateTime? Entrada { get; set; }
        public DateTime? Saida { get; set; }
        public float? Valor { get; set; }
        public int VagaId { get;  set; }
        public int ClienteId { get; set; }
        public int VeiculoId { get; set; }

    }
}
