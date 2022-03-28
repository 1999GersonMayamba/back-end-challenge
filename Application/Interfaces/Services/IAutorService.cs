using System;
using Application.DTOs;
using Application.Wrappers;
using System.Collections.Generic;
using System.Threading.Tasks;



namespace Application.Interfaces.Services
{
	public interface IAutorService
	{
		Task<Response<Guid>> RegisterAsync(AutorRegisterDTO autorDTO);
		Task<Response<Guid>> RemoveAsync(AutorDTO autorDTO);
		Task<Response<Guid>> UpdateAsync(AutorDTO autorDTO);
		Task<Response<AutorDTO>> GetById(Guid id);
		Task<Response<List<AutorDTO>>> GetAll();
	}
}
