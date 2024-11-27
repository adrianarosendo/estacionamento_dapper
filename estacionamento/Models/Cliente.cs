using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace estacionamento.Models
{
    [Table("clientes")]
    public class Cliente
    {
        public required int Id { get; set; }
        public string? Nome { get; set; }
        public string? CPF { get; set; }
        public string? Telefone { get; set; }

    }
}
