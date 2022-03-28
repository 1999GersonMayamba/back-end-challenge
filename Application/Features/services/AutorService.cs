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
		public class AutorService : IAutorService
		{
				private readonly IMapper _mapper;
				private readonly IAutorRepository _autorRepository;
				private ILog logger;


				public AutorService(IAutorRepository autorRepository, IMapper mapper, ILog logger)
				{
						_mapper = mapper;
						this._autorRepository = autorRepository;
						this.logger = logger;
				}


				public async Task<Response<List<AutorDTO>>> GetAll()
				{
					try
					{
						 return new Response<List<AutorDTO>>
						(_mapper.Map<List<AutorDTO>>(await this._autorRepository.GetAllAsync()));
					}
					catch (System.Exception ex)
					{
						this.logger.Error(ex.Message);
						throw new ApiException(ex.Message);
					}
				}


				public async Task<Response<AutorDTO>> GetById(Guid id)
				{
					try
					{
						 return new Response<AutorDTO>
						(_mapper.Map<AutorDTO>(await this._autorRepository.GetByGUIDAsync(id)));
					}
					catch (System.Exception ex)
					{
						this.logger.Error(ex.Message);
						throw new ApiException(ex.Message);
					}
				}


				public async Task<Response<Guid>> RegisterAsync(AutorRegisterDTO autorDTO)
				{
					try
					{
						var result = _mapper.Map<Autor>(autorDTO);
						result.IdAutor = Guid.NewGuid();
						await _autorRepository.AddAsync(result);
						return new Response<Guid>(result.IdAutor, Constantes.Constantes.RegistoSalvo);
					}
					catch (System.Exception ex)
					{
						this.logger.Error(ex.Message);
						throw new ApiException(ex.Message);
					}
				}


				public async Task<Response<Guid>> RemoveAsync(AutorDTO autorDTO)
				{
					try
					{
						var result = _mapper.Map<Autor>(autorDTO);
						await _autorRepository.DeleteAsync(result);
						return new Response<Guid>(result.IdAutor, Constantes.Constantes.RegistoEliminado);
					}
					catch (System.Exception ex)
					{
						this.logger.Error(ex.Message);
						throw new ApiException(ex.Message);
					}
				}


				public async Task<Response<Guid>> UpdateAsync(AutorDTO autorDTO)
				{
					try
					{
						var result = _mapper.Map<Autor>(autorDTO);
						await _autorRepository.UpdateAsync(result);
						return new Response<Guid>(result.IdAutor,  Constantes.Constantes.RegistoActualizado);
					}
					catch (System.Exception ex)
					{
						this.logger.Error(ex.Message);
						throw new ApiException(ex.Message);
					}
				}


		}
}
