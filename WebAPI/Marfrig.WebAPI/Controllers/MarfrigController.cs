using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Marfrig.Domain;
using Marfrig.Repository;
using Marfrig.WebAPI.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Marfrig.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarfrigController : ControllerBase
    {
        public readonly IMarfrigRepository _repository;
        private readonly IMapper _mapper;

        public MarfrigController(IMarfrigRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        // GET api/evento
        [HttpGet]
        [Produces(typeof(CompraGadoItem))]
        [Route("/api/Marfrig/")]
        public async Task<IActionResult> Get()
        {
            try
            {
                var compraGadoItens = await _repository.GetAllCompraGadoItemAsync(true);
                var results = _mapper.Map<IEnumerable<CompraGadoItemDto>>(compraGadoItens);
                return Ok(results);
            }
            catch (System.Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Banco de dados falhou {ex.Message}");
            }
        }

        // GET api/evento
        [HttpGet("{CompraGadoItemId}")]
        [Produces(typeof(CompraGadoItem))]
        public async Task<IActionResult> Get(int CompraGadoItemId)
        {
            try
            {
                var compraGadoItens = await _repository.GetCompraGadoItemAsyncById(CompraGadoItemId, true);
                var results = _mapper.Map<CompraGadoItemDto>(compraGadoItens);
                return Ok(results);
            }
            catch (System.Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de dados falhou");
            }
            
        }        

        // POST api/evento
        [HttpPost]
        public async Task<IActionResult> Post(CompraGadoItem model)
        {
            try
            {
                var compraGadoItens = _mapper.Map<CompraGadoItem>(model);
                _repository.Add(compraGadoItens);
                
                if(await _repository.SaveChangesAsync())
                {
                    return Created($"/api/marfrig/{model.Id}", _mapper.Map<CompraGadoItemDto>(compraGadoItens));
                }
            }
            catch (System.Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Banco de dados falhou {ex.Message}");
            }
            
            return BadRequest();
        }

        // PUT api/evento
        [HttpPut("{CompraGadoItemId}")]
        public async Task<IActionResult> Put(int CompraGadoItemId, CompraGadoItemDto model)
        {
            try
            {
                var compraGadoItens = await _repository.GetCompraGadoItemAsyncById(CompraGadoItemId, false);
                if(compraGadoItens == null) return NotFound();

                _mapper.Map(model, compraGadoItens);

                _repository.Update(compraGadoItens);
                
                if(await _repository.SaveChangesAsync())
                {
                    return Created($"/api/marfrig/{model.Id}", model);
                }
            }
            catch (System.Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Banco de dados falhou {ex.Message}");
            }
            
            return BadRequest();
        }

        // DELETE api/evento
        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete(int Id)
        {
            try
            {
                var compraGadoItens = await _repository.GetCompraGadoItemAsyncById(Id, false);
                if(compraGadoItens == null) return NotFound();
                  
                _repository.Add(compraGadoItens);
                
                if(await _repository.SaveChangesAsync())
                {
                    return Ok();
                }
            }
            catch (System.Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Banco de dados falhou {ex.Message}");
            }
            
            return BadRequest();
        }
    }
}