using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TaskColegio.Model;
namespace TaskColegio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfesoresController : ControllerBase
    {
        protected ColegioContext ct= new ColegioContext();
        [HttpPut]
        public ActionResult Put([FromBody] Profesor nuevoProfesor){
            ct.Profesor.Add(nuevoProfesor);
            ct.SaveChanges();
            return Ok();
        }
        [HttpDelete]
        public ActionResult Delete(string cedula){
            var query  = ct.Profesor.Where( p => p.Cedula == cedula).First();
            Profesor eliminar = (Profesor) query;
            ct.Profesor.Remove(eliminar);
            ct.SaveChanges();
            return Ok();
        }
    }
}
