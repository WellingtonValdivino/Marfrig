using AutoMapper;
using Marfrig.Domain;
using Marfrig.Repository.Interface;
using Marfrig.WebAPI.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Marfrig.WebAPI.Controllers
{
    [Route("api/Marfrig/[controller]")]
    [ApiController]
    public class CompraGadoController : ControllerBase
    {
        private readonly ICompraGadoRepository _repository;
        private readonly IMapper _mapper;

        public CompraGadoController(ICompraGadoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        [Produces(typeof(CompraGado))]
        public async Task<IActionResult> Get()
        {
            try
            {
                var compraGado = await _repository.GetAllCompraGadoAsync(true);
                var results = _mapper.Map<IEnumerable<CompraGadoDto>>(compraGado);
                return Ok(results);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Banco de dados falhou {ex.Message}");
            }
        }

        [HttpGet("{CompraGadoId}")]
        [Produces(typeof(CompraGado))]
        public async Task<IActionResult> Get(int CompraGadoId)
        {
            try
            {
                var compraGado = await _repository.GetCompraGadoAsyncById(CompraGadoId, true);
                var results = _mapper.Map<CompraGadoDto>(compraGado);
                return Ok(results);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Banco de dados falhou");
            }

        }

        [HttpPost]
        public async Task<IActionResult> Post(CompraGado model)
        {
            try
            {
                var compraGado = _mapper.Map<CompraGado>(model);
                _repository.Add(compraGado);

                if (await _repository.SaveChangesAsync())
                {
                    return Created($"/api/marfrig/{model.Id}", _mapper.Map<CompraGadoDto>(compraGado));
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Banco de dados falhou {ex.Message}");
            }

            return BadRequest();
        }

        [HttpPut("{CompraGadoId}")]
        public async Task<IActionResult> Put(int CompraGadoId, CompraGadoDto model)
        {
            try
            {
                var compraGado = await _repository.GetCompraGadoAsyncById(CompraGadoId, false);
                if (compraGado == null) return NotFound();

                _mapper.Map(model, compraGado);

                _repository.Update(compraGado);

                if (await _repository.SaveChangesAsync())
                {
                    return Created($"/api/marfrig/{model.Id}", model);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Banco de dados falhou {ex.Message}");
            }

            return BadRequest();
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete(int Id)
        {
            try
            {
                var compraGado = await _repository.GetCompraGadoAsyncById(Id, false);
                if (compraGado == null) return NotFound();

                _repository.Add(compraGado);

                if (await _repository.SaveChangesAsync())
                {
                    return Ok();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Banco de dados falhou {ex.Message}");
            }

            return BadRequest();
        }
    }
}