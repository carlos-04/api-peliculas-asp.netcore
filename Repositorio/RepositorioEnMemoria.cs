using PeliculaApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeliculaApi.Repositorio
{
    public class RepositorioEnMemoria : IRepositorio
    {

        private List<Generos> _generos;
        public RepositorioEnMemoria()
        {
            _generos = new List<Generos>()
           {
               new Generos() {Id = 1, Nombre="Accion"},
               new Generos() {Id = 2, Nombre="Comedia" }
                
           };
                
        }
        public List<Generos> ObtenerTodosGeneros()
        {
            return _generos;
        }
        public async Task <Generos> obtenerGeneroPorId(int id)
        {
            await Task.Delay(1);
            return  _generos.FirstOrDefault(x => x.Id == id);
        }

    


    }
}
