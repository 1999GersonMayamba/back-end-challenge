using System;
using Application.DTOs;
using Application.Wrappers;
using System.Collections.Generic;
using System.Threading.Tasks;



namespace Application.Interfaces.Services
{
	public interface ILivroService
		{
			Task<Response<Guid>> RegisterAsync(LivroRegisterDTO livroDTO);
			Task<Response<Guid>> RemoveAsync(LivroDTO livroDTO);
			Task<Response<Guid>> UpdateAsync(LivroDTO livroDTO);
	     	Task<Response<LivroRequestDTO>> GetById(Guid id);
		    Task<Response<List<LivroRequestDTO>>> GetAll();
		}
}
