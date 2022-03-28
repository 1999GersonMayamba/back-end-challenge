/*Gerado no Gerador de Codigo UCALL
Data: 28/03/2022 00:07:25
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
		public class LivroController : ControllerBase
	{
				private readonly ILivroService _livroService;


				public LivroController(ILivroService livroService)
				{
					this._livroService = livroService;
				}




				[HttpGet]
				public async Task<IActionResult> GetAll()
				{
						return Ok(await _livroService.GetAll());
				}




				[HttpGet("{id}")]
				public async Task<IActionResult> GetById(Guid id)
				{
						return Ok(await _livroService.GetById(id));
				}




				[HttpPost("register")]
				public async Task<IActionResult> RegisterAsync(LivroRegisterDTO request)
				{
						return Ok(await _livroService.RegisterAsync(request));
				}




				[HttpDelete("delete")]
				public async Task<IActionResult> DeleyteAsync(LivroDTO request)
				{
						return Ok(await _livroService.RemoveAsync(request));
				}




				[HttpPut("update")]
				public async Task<IActionResult> UpdateteAsync(LivroDTO request)
				{
						return Ok(await _livroService.UpdateAsync(request));
				}


		}
}
