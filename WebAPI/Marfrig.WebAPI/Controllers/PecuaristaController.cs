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
    public class PecuaristaController : ControllerBase
    {
        private readonly IPecuaristaRepository _repository;
        private readonly IMapper _mapper;

        public PecuaristaController(IPecuaristaRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        [Produces(typeof(Pecuarista))]
        public async Task<IActionResult> Get()
        {
            try
            {
                var compraGado = await _repository.GetAllPecuaristaAsync();
                var results = _mapper.Map<IEnumerable<PecuaristaDto>>(compraGado);
                return Ok(results);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Banco de dados falhou {ex.Message}");
            }
        }

        [HttpGet("{PecuaristaId}")]
        [Produces(typeof(Pecuarista))]
        public async Task<IActionResult> Get(int PecuaristaId)
        {
            try
            {
                var pecuarista = await _repository.GetPecuaristaAsyncById(PecuaristaId);
                var results = _mapper.Map<PecuaristaDto>(pecuarista);
                return Ok(results);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Banco de dados falhou");
            }

        }

        [HttpPost]
        public async Task<IActionResult> Post(Pecuarista model)
        {
            try
            {
                var pecuarista = _mapper.Map<Pecuarista>(model);
                _repository.Add(pecuarista);

                if (await _repository.SaveChangesAsync())
                {
                    return Created($"/api/marfrig/{model.Id}", _mapper.Map<PecuaristaDto>(pecuarista));
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Banco de dados falhou {ex.Message}");
            }

            return BadRequest();
        }

        [HttpPut("{CompraGadoId}")]
        public async Task<IActionResult> Put(int CompraGadoId, PecuaristaDto model)
        {
            try
            {
                var pecuarista = await _repository.GetPecuaristaAsyncById(CompraGadoId);
                if (pecuarista == null) return NotFound();

                _mapper.Map(model, pecuarista);

                _repository.Update(pecuarista);

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
                var pecuarista = await _repository.GetPecuaristaAsyncById(Id);
                if (pecuarista == null) return NotFound();

                _repository.Add(pecuarista);

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
