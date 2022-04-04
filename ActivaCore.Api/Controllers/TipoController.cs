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
using Microsoft.AspNetCore.Http;

namespace ActivaCore.Api.Controllers
{
    [Route("Api/[controller]")]
    [ApiController]
    public class TipoController : Controller
    {

        public TipoService TipoService { get; }
        // GET: TipoController

        private IMapper _mapper;

        public TipoController(TipoService tipoService)
        {
            TipoService = tipoService;
        }


        [HttpGet]
        public IActionResult Get()
        //public IEnumerable<Models.Tipo> Get()
        {
            return Ok(TipoService.GetList());
        }

        [HttpGet("{id}")]
        public Domain.Tipo Get(int id)
        {
            return TipoService.Get(id);
        }

        [HttpPost]
        public IActionResult CreateTipo([FromBody] TipoCreate tipo)
        {
            TipoService.Create(tipo.Descripcion, tipo.IdSubTipo);
            return StatusCode(200);
        }

        [HttpPut("{id}")]
        //[Route("UpdatePost")]
        public IActionResult UpdatePost(int id, [FromBody] Domain.Tipo tipo)
        {
            tipo.IdTipo = id;
            TipoService.Update(tipo);
            return Ok(tipo);
        }

        [HttpDelete("{id}")]
        //[Route("UpdatePost")]
        public IActionResult DeleteTipo(int id, [FromBody] Domain.Tipo tipo)
        {
            tipo =  TipoService.Get(id);
            tipo.FechaEdicion = DateTime.Now;
            tipo.UsuarioEdicion = 5;
            tipo.Activo = false;            
            TipoService.Update(tipo);
            return Ok(tipo);
        }
    }
}
