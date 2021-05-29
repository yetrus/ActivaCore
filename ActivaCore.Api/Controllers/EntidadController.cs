using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ActivaCore.Application;
using ActivaCore.Domain;
using ActivaCore.Helpers;
using ActivaCore.Api.Models;

namespace ActivaCore.Api.Controllers
{
    [Route("Api/[controller]")]
    [ApiController]
    public class EntidadController : Controller
    {

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
        public IActionResult CreateEntidad([FromBody] CreateEntidad entidad)
        {
            EntidadService.Create(entidad.Nombre);
            return StatusCode(200);
        }


    }
}
