using Application.Interfaces.Repositories;
using Domain.Entities;
using Infrastructure.Persistence.Contexts;
using Infrastructure.Persistence.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Repositories
{
		public class LivroRepository : GenericRepositoryAsync<Livro>, ILivroRepository
		{
				private readonly DbSet<Livro> _livro;


				public LivroRepository(ApplicationDbContext dbContext) : base(dbContext)
				{
						this._livro = dbContext.Set<Livro>();
				}

				public async Task<List<Livro>> GetAllLivros()
				{
			        var livros = await this._dbContext.Livro.Include(x => x.Genero)
											.Include(x => x.Autor).AsNoTracking().ToListAsync();
					return livros;
				}

				public async Task<Livro> GetLivroById(Guid IdLivro)
				{
					var livro = await this._dbContext.Livro.Include(x => x.Genero)
											.Include(x => x.Autor).Where(x => x.IdLivro == IdLivro)
											.AsNoTracking().FirstOrDefaultAsync();
					return livro;
				}


			}
}
