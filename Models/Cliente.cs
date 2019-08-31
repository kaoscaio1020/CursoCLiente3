using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CursoCliente3.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get;set; }
        [Required]
        public string Nome { get;set; }
        public int Idade { get;set; }
        public string Email { get;set; }
        public DateTime DataEntrada { get;set; }
        public DateTime DataSaida { get;set; }
        public int CursoId { get; set;}
        public Curso Curso { get; set; }
    }
}