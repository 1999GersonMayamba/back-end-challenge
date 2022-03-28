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
		public class GeneroService : IGeneroService
		{
				private readonly IMapper _mapper;
				private readonly IGeneroRepository _generoRepository;
				private ILog logger;


				public GeneroService(IGeneroRepository generoRepository, IMapper mapper, ILog logger)
				{
						_mapper = mapper;
						this._generoRepository = generoRepository;
						this.logger = logger;
				}


				public async Task<Response<List<GeneroDTO>>> GetAll()
				{
					try
					{
						 return new Response<List<GeneroDTO>>
						(_mapper.Map<List<GeneroDTO>>(await this._generoRepository.GetAllAsync()));
					}
					catch (System.Exception ex)
					{
						this.logger.Error(ex.Message);
						throw new ApiException(ex.Message);
					}
				}


				public async Task<Response<GeneroDTO>> GetById(Guid id)
				{
					try
					{
						 return new Response<GeneroDTO>
						(_mapper.Map<GeneroDTO>(await this._generoRepository.GetByGUIDAsync(id)));
					}
					catch (System.Exception ex)
					{
						this.logger.Error(ex.Message);
						throw new ApiException(ex.Message);
					}
				}


				public async Task<Response<Guid>> RegisterAsync(GeneroRegisterDTO generoDTO)
				{
					try
					{
						var result = _mapper.Map<Genero>(generoDTO);
						result.IdGenero = Guid.NewGuid();
						await _generoRepository.AddAsync(result);
						return new Response<Guid>(result.IdGenero, Constantes.Constantes.RegistoSalvo);
					}
					catch (System.Exception ex)
					{
						this.logger.Error(ex.Message);
						throw new ApiException(ex.Message);
					}
				}


				public async Task<Response<Guid>> RemoveAsync(GeneroDTO generoDTO)
				{
					try
					{
						var result = _mapper.Map<Genero>(generoDTO);
						await _generoRepository.DeleteAsync(result);
						return new Response<Guid>(result.IdGenero, Constantes.Constantes.RegistoEliminado);
					}
					catch (System.Exception ex)
					{
						this.logger.Error(ex.Message);
						throw new ApiException(ex.Message);
					}
				}


				public async Task<Response<Guid>> UpdateAsync(GeneroDTO generoDTO)
				{
					try
					{
						var result = _mapper.Map<Genero>(generoDTO);
						await _generoRepository.UpdateAsync(result);
						return new Response<Guid>(result.IdGenero,  Constantes.Constantes.RegistoActualizado);
					}
					catch (System.Exception ex)
					{
						this.logger.Error(ex.Message);
						throw new ApiException(ex.Message);
					}
				}


		}
}
