using AutoMapper;
using Marfrig.Domain;
using Marfrig.Repository.Interface;
using Marfrig.WebAPI.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Marfrig.WebAPI.Controllers
{
    [Route("api/Marfirg/[controller]")]
    [ApiController]
    public class CompraGadoItemController : ControllerBase
    {
        private readonly ICompraGadoItemRepository _repository;
        private readonly IMapper _mapper;

        public CompraGadoItemController(ICompraGadoItemRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        [Produces(typeof(CompraGadoItem))]
        public async Task<IActionResult> Buscar()
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

        [HttpGet("{CompraGadoItemId}")]
        public async Task<IActionResult> BuscarId(int CompraGadoItemId)
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

        [HttpPost]
        public async Task<IActionResult> Inserir(CompraGadoItem model)
        {
            try
            {
                var compraGadoItens = _mapper.Map<CompraGadoItem>(model);
                _repository.Add(compraGadoItens);
                
                if(await _repository.SaveChangesAsync())
                {
                    return Created($"/api/marfrig/CompraGadoItem/Inserir/{model.Id}", _mapper.Map<CompraGadoItemDto>(compraGadoItens));
                }
            }
            catch (System.Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Banco de dados falhou {ex.Message}");
            }
            
            return BadRequest();
        }

        [HttpPut]
        public async Task<IActionResult> Atualizar(int CompraGadoItemId, CompraGadoItemDto model)
        {
            try
            {
                var compraGadoItens = await _repository.GetCompraGadoItemAsyncById(CompraGadoItemId, false);
                if(compraGadoItens == null) return NotFound();

                _mapper.Map(model, compraGadoItens);

                _repository.Update(compraGadoItens);
                
                if(await _repository.SaveChangesAsync())
                {
                    return Created($"/api/marfrig/CompraGadoItem/Atualizar{model.Id}", model);
                }
            }
            catch (System.Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Banco de dados falhou {ex.Message}");
            }
            
            return BadRequest();
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Deletar(int Id)
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