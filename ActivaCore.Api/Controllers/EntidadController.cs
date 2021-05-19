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
        public IEnumerable<Entidad> Get()
        {
            return EntidadService.GetList();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
