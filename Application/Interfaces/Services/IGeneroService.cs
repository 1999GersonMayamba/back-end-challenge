using System;
using Application.DTOs;
using Application.Wrappers;
using System.Collections.Generic;
using System.Threading.Tasks;



namespace Application.Interfaces.Services
{
	public interface IGeneroService
		{
			Task<Response<Guid>> RegisterAsync(GeneroRegisterDTO generoDTO);
			Task<Response<Guid>> RemoveAsync(GeneroDTO generoDTO);
			Task<Response<Guid>> UpdateAsync(GeneroDTO generoDTO);
			Task<Response<GeneroDTO>> GetById(Guid id);
			Task<Response<List<GeneroDTO>>> GetAll();
		}
}
