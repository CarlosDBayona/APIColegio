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
    public class CursosController : ControllerBase
    {
        protected ColegioContext ct= new ColegioContext();
        [HttpPut]
        public ActionResult Put([FromBody] Curso nuevoRegistro){
            ct.Curso.Add(nuevoRegistro);
            ct.SaveChanges();
            return Ok();
        }
        [HttpPost("Notas")]
        public ActionResult Update([FromBody] Curso actualizarRegistro){
            var query = ct.Curso.Where( c => c.IdAlumno ==  actualizarRegistro.IdAlumno && c.IdMateria ==actualizarRegistro.IdMateria).First();
            Curso cursoActual = (Curso) query;
            cursoActual.Periodo1 = actualizarRegistro.Periodo1;
            cursoActual.Periodo2 = actualizarRegistro.Periodo2;
            ct.Curso.Update(cursoActual);
            ct.SaveChanges();
            return Ok();
        }
    }
}
