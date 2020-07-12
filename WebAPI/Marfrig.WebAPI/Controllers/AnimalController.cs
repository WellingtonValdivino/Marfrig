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
    public class AnimalController : ControllerBase
    {
        private readonly IAnimalRepository _repository;
        private readonly IMapper _mapper;

        public AnimalController(IAnimalRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        [Produces(typeof(Animal))]
        public async Task<IActionResult> Get()
        {
            try
            {
                var animal = await _repository.GetAllAnimalAsync();
                var results = _mapper.Map<IEnumerable<AnimalDto>>(animal);
                return Ok(results);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Banco de dados falhou {ex.Message}");
            }
        }

        [HttpGet("{AnimalId}")]
        [Produces(typeof(Animal))]
        public async Task<IActionResult> Get(int AnimalId)
        {
            try
            {
                var animal = await _repository.GetAnimalAsyncById(AnimalId);
                var results = _mapper.Map<AnimalDto>(animal);
                return Ok(results);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Banco de dados falhou");
            }

        }

        [HttpPost]
        public async Task<IActionResult> Post(Animal model)
        {
            try
            {
                var animal = _mapper.Map<Animal>(model);
                _repository.Add(animal);

                if (await _repository.SaveChangesAsync())
                {
                    return Created($"/api/marfrig/{model.Id}", _mapper.Map<AnimalDto>(animal));
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Banco de dados falhou {ex.Message}");
            }

            return BadRequest();
        }

        [HttpPut("{AnimalId}")]
        public async Task<IActionResult> Put(int AnimalId, AnimalDto model)
        {
            try
            {
                var animal = await _repository.GetAnimalAsyncById(AnimalId);
                if (animal == null) return NotFound();

                _mapper.Map(model, animal);

                _repository.Update(animal);

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
                var animal = await _repository.GetAnimalAsyncById(Id);
                if (animal == null) return NotFound();

                _repository.Add(animal);

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
