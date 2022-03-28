/*Gerado no Gerador de Codigo UCALL
Data: 28/03/2022 00:07:21
*/

using Application.DTOs;
using Application.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebApi.Controllers


{
		[Route("api/[controller]")]
		[ApiController]
		public class GeneroController :  ControllerBase
		{
				private readonly IGeneroService _generoService;


				public GeneroController(IGeneroService generoService)
				{
					this._generoService = generoService;
				}




				[HttpGet]
				public async Task<IActionResult> GetAll()
				{
						return Ok(await _generoService.GetAll());
				}




				[HttpGet("{id}")]
				public async Task<IActionResult> GetById(Guid id)
				{
						return Ok(await _generoService.GetById(id));
				}




				[HttpPost("register")]
				public async Task<IActionResult> RegisterAsync(GeneroRegisterDTO request)
				{
						return Ok(await _generoService.RegisterAsync(request));
				}




				[HttpDelete("delete")]
				public async Task<IActionResult> DeleyteAsync(GeneroDTO request)
				{
						return Ok(await _generoService.RemoveAsync(request));
				}




				[HttpPut("update")]
				public async Task<IActionResult> UpdateteAsync(GeneroDTO request)
				{
						return Ok(await _generoService.UpdateAsync(request));
				}


		}
}
