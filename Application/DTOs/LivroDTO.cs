using System;



namespace Application.DTOs
{
		public class LivroDTO
		{
			public Guid IdLivro { get; set; }
			public string Titulo { get; set; }
			public int QtdCopias { get; set; }
			public Guid IdAutor { get; set; }
			public Guid IdGenero { get; set; }
		}
}
