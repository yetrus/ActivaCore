using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ActivaCore.Application;
using ActivaCore.Domain;
using ActivaCore.Helpers;
using ActivaCore.Api.Models;
using AutoMapper;

namespace ActivaCore.Api.Controllers
{
    [Route("Api/[controller]")]
    [ApiController]
    public class EntidadController : Controller
    {

        private IMapper _mapper;
        public EntidadService EntidadService { get; }

        public EntidadController(EntidadService entidadService)
        {
            EntidadService = entidadService;
        }

        [HttpGet]
        public IActionResult Get()
        //public IEnumerable<Entidad> Get()
        {
            return Ok(EntidadService.GetList());
        }

        [HttpGet("{id}")]
        public Domain.Entidad Get(int id)
        {
            return EntidadService.Get(id);
        }


        [HttpPost]
        public IActionResult CreateEntidad([FromBody] EntidadCreate entidad)
        {
            EntidadService.Create(entidad.Rut, entidad.Nombre);
            return StatusCode(200);
        }

        [HttpDelete("{id}")]
        public void DeleteEntidad(int id)
        {
            var entidad = EntidadService.Get(id);
            EntidadService.Delete(entidad);
        }

        //[HttpPut("{id}")]
        //public void UpdateEntidad(int id, [FromBody] EntidadUpdate entidadUpdate)
        //{
        //    var entidadEntity = EntidadService.Get(id);

        //    _mapper.Map<Domain.Entidad>(entidadEntity);

        //    // entidad.IdEntidad = id;

        //    EntidadService.Update(entidad);
        //}
    }
}
