using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CursoCliente3.Models
{
    public class Curso
    {
        [Key]
        public int Id { get;set; }
        [Required]
        public string Nome { get;set; }
        public DateTime DataInicial { get;set; }
        public DateTime DataFInal { get;set; }

        [ForeignKey("CursoId")]        
        public virtual IList<Cliente> Clientes { get; set; }
    }
}