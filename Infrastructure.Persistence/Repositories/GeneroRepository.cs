using Application.Interfaces.Repositories;
using Domain.Entities;
using Infrastructure.Persistence.Contexts;
using Infrastructure.Persistence.Repository;
using Microsoft.EntityFrameworkCore;



namespace Infrastructure.Persistence.Repositories
{
		public class GeneroRepository : GenericRepositoryAsync<Genero>, IGeneroRepository
		{
				private readonly DbSet<Genero> _genero;


				public GeneroRepository(ApplicationDbContext dbContext) : base(dbContext)
				{
						this._genero = dbContext.Set<Genero>();
				}


		}
}
