using PeliculaApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeliculaApi.Repositorio
{
   public interface IRepositorio
    {
      public  List<Generos> ObtenerTodosGeneros();
        public Task<Generos> obtenerGeneroPorId(int id);
    }
}
