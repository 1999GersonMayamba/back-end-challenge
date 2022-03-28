using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs
{
   public class LivroRequestDTO
    {
        public string Titulo { get; set; }
        public int QtdCopias { get; set; }
        public AutorDTO Autor { get; set; }
        public GeneroDTO Genero { get; set; }
    }
}
