using Application.Interfaces.Repositories;
using Domain.Entities;
using Infrastructure.Persistence.Contexts;
using Infrastructure.Persistence.Repository;
using Microsoft.EntityFrameworkCore;



namespace Infrastructure.Persistence.Repositories
{
		public class AutorRepository : GenericRepositoryAsync<Autor>, IAutorRepository
		{
				private readonly DbSet<Autor> _autor;


				public AutorRepository(ApplicationDbContext dbContext) : base(dbContext)
				{
						this._autor = dbContext.Set<Autor>();
				}


		}
}
