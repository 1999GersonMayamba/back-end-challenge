using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Entities
{
   public class Livro
    {
        [Key]
        public Guid IdLivro { get; set; }
        public string Titulo { get; set; }
        public int QtdCopias { get; set; }
        public Guid IdAutor { get; set; }
        [ForeignKey("IdAutor")]
        public virtual Autor Autor { get; set; }
        public Guid IdGenero { get; set; }
        [ForeignKey("IdGenero")]
        public virtual Genero Genero { get; set; }

    }
}
