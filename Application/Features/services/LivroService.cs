using Application.DTOs;
using Application.Exceptions;
using Application.Interfaces;
using Application.Interfaces.NLog;
using Application.Interfaces.Repositories;
using Application.Interfaces.Services;
using Application.Wrappers;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Application.Features.services
{
		public class LivroService : ILivroService
		{
				private readonly IMapper _mapper;
				private readonly ILivroRepository _livroRepository;
				private ILog logger;
				public LivroService(ILivroRepository livroRepository, IMapper mapper, ILog logger)
				{
						_mapper = mapper;
						this._livroRepository = livroRepository;
						this.logger = logger;
				}


				public async Task<Response<List<LivroRequestDTO>>> GetAll()
				{
					try
					{
						 return new Response<List<LivroRequestDTO>>
						(_mapper.Map<List<LivroRequestDTO>>(await this._livroRepository.GetAllLivros()));
					}
					catch (System.Exception ex)
					{
						this.logger.Error(ex.Message);
						throw new ApiException(ex.Message);
					}
				}


				public async Task<Response<LivroRequestDTO>> GetById(Guid id)
				{
					try
					{
						 return new Response<LivroRequestDTO>
						(_mapper.Map<LivroRequestDTO>(await this._livroRepository.GetLivroById(id)));
					}
					catch (System.Exception ex)
					{
						this.logger.Error(ex.Message);
						throw new ApiException(ex.Message);
					}
				}


				public async Task<Response<Guid>> RegisterAsync(LivroRegisterDTO livroDTO)
				{
					try
					{
						var result = _mapper.Map<Livro>(livroDTO);
						result.IdLivro = Guid.NewGuid();
						await _livroRepository.AddAsync(result);
						return new Response<Guid>(result.IdLivro, Constantes.Constantes.RegistoSalvo);
					}
					catch (System.Exception ex)
					{
						this.logger.Error(ex.Message);
						throw new ApiException(ex.Message);
					}
				}


				public async Task<Response<Guid>> RemoveAsync(LivroDTO livroDTO)
				{
					try
					{
						var result = _mapper.Map<Livro>(livroDTO);
						await _livroRepository.DeleteAsync(result);
						return new Response<Guid>(result.IdLivro, Constantes.Constantes.RegistoEliminado);
					}
					catch (System.Exception ex)
					{
						this.logger.Error(ex.Message);
						throw new ApiException(ex.Message);
					}
				}


				public async Task<Response<Guid>> UpdateAsync(LivroDTO livroDTO)
				{
					try
					{
						var result = _mapper.Map<Livro>(livroDTO);
						await _livroRepository.UpdateAsync(result);
						return new Response<Guid>(result.IdLivro,  Constantes.Constantes.RegistoActualizado);
					}
					catch (System.Exception ex)
					{
						this.logger.Error(ex.Message);
						throw new ApiException(ex.Message);
					}
				}


		}
}
