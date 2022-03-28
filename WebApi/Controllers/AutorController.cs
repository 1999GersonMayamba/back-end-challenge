/*Gerado no Gerador de Codigo UCALL
Data: 28/03/2022 00:07:17
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
		public class AutorController : ControllerBase
	{
				private readonly IAutorService _autorService;


				public AutorController(IAutorService autorService)
				{
					this._autorService = autorService;
				}




				[HttpGet]
				public async Task<IActionResult> GetAll()
				{
						return Ok(await _autorService.GetAll());
				}




				[HttpGet("{id}")]
				public async Task<IActionResult> GetById(Guid id)
				{
						return Ok(await _autorService.GetById(id));
				}




				[HttpPost("register")]
				public async Task<IActionResult> RegisterAsync(AutorRegisterDTO request)
				{
						return Ok(await _autorService.RegisterAsync(request));
				}




				[HttpDelete("delete")]
				public async Task<IActionResult> DeleyteAsync(AutorDTO request)
				{
						return Ok(await _autorService.RemoveAsync(request));
				}




				[HttpPut("update")]
				public async Task<IActionResult> UpdateteAsync(AutorDTO request)
				{
						return Ok(await _autorService.UpdateAsync(request));
				}


		}
}
