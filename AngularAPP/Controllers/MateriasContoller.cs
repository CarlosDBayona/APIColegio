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
    public class MateriasController : ControllerBase
    {
        protected ColegioContext ct= new ColegioContext();
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            
            var query = ct.Alumno.Where( s => s.Nombre == "Carlos").First<Alumno>();
            Alumno p = (Alumno) query;
            return new string[] { p.Apellido,  "value2" };
        }
        [HttpPut]
        public ActionResult Put([FromBody] Materia nuevaMateria){
            ct.Materia.Add(nuevaMateria);
            ct.SaveChanges();
            return Ok();
        } 

        [HttpPost]
        public ActionResult AgregarMateria([FromForm] string idAlumno, [FromForm] string idProfesor){
            Materia materia = new Materia();
            Console.WriteLine(idAlumno);
            Console.WriteLine(idProfesor);
            //materia.IdAlumno = idAlumno;
            //materia.IdProfesor = idProfesor;
            //ct.Materia.Add(nuevaMateria);
            //ct.SaveChanges();
            return Ok();
        } 
    }
}
