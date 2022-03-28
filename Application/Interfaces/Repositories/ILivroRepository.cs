using System;
using Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;



namespace Application.Interfaces.Repositories
{
	public interface ILivroRepository : IGenericRepositoryAsync<Livro>
	{
			Task<List<Livro>> GetAllLivros();
		    Task<Livro> GetLivroById(Guid IdLivro);
	}
}
