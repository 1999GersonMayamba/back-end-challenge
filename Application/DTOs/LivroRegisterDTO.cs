using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs
{
   public class LivroRegisterDTO
    {
		public string Titulo { get; set; }
		public int QtdCopias { get; set; }
		public Guid IdAutor { get; set; }
		public Guid IdGenero { get; set; }
	}
}
