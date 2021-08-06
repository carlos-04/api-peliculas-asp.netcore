using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using PeliculaApi.Models;
using PeliculaApi.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeliculaApi.Controllers
{

    [Route("api/generos")]
    public class GeneroController : ControllerBase
    {
        private readonly IRepositorio _generos;
          public GeneroController(IRepositorio repositorio)
           {
             this._generos = repositorio;
           }
  
       [HttpGet]  
        public ActionResult <List<Generos>> Get()
        {
            return _generos.ObtenerTodosGeneros();
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task <ActionResult <Generos>> Get(int id, [BindRequired] string nombre)
        {
            var genero = await _generos.obtenerGeneroPorId(id);
            
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState); //sino es valido me retorna un error 404
            }

            if(genero == null)
            {
                return NotFound();
            }

            return genero;
        }
        [HttpPost]
        public ActionResult Post( [FromBody] Generos genero)
        {
            return NoContent();
        }

        [HttpPut]
        public ActionResult Put()
        {
            return NoContent();
        }
        [HttpDelete]
        public ActionResult Delete()
        {
            return NoContent();
        }



    }
}

