using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskColegio.Model;
namespace TaskColegio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstudiantesController : ControllerBase
    {
        protected ColegioContext ct= new ColegioContext();
        // GET api/values
        [HttpGet("{id}")]
        public ActionResult Get( string id )
        {
            var query = ct.Alumno.Where(s => s.Id == id).FirstOrDefault();
            var queryCurso = (from Curso curso in ct.Curso
                              join Materia in ct.Materia on curso.IdMateria equals Materia.IdMateria
                              join Profesor in ct.Profesor on Materia.IdProfesor equals Profesor.Cedula
                              where curso.IdAlumno==id
                              select new { idMateria = curso.IdMateria, periodo1 = curso.Periodo1, periodo2 = curso.Periodo2, Materia = Materia.Nombre, profesorNombre = Profesor.Nombre,
                              profesorApellido = Profesor.Apellido});
            var queryMateria = (from Curso curso in ct.Curso where curso.IdAlumno == id select curso.IdMateria);

            Alumno alumno = (Alumno) query;
            return Ok(new { alumno_info =  alumno, materia= queryCurso.ToArray()});
        }
        [HttpPut]
        public ActionResult Put([FromBody] Alumno nuevoAlumno){
            ct.Alumno.Add(nuevoAlumno);
            ct.SaveChanges();
            return Ok();
        }
        [HttpPost]
        public ActionResult Update([FromBody] Alumno alumno){
            ct.Alumno.Update(alumno);
            ct.SaveChanges();
            return Ok(alumno);
        } 
    }
}
