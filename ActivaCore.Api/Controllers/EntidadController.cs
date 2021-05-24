using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ActivaCore.Application;
using ActivaCore.Domain;
using ActivaCore.Helpers;

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
        public Entidad Get(int id)
        {            
            return EntidadService.Get(id);
        }


        [HttpPost]
        public void Post([FromBody] Entidad entidad)
        {
            EntidadService.Create(entidad.Nombre);
        }

        
    }
}
