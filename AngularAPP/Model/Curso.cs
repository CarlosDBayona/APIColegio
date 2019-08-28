using System;
using System.Collections.Generic;

namespace TaskColegio.Model
{
    public partial class Curso
    {
        public int Id { get; set; }
        public string IdAlumno { get; set; }
        public string IdMateria { get; set; }
        public double? Periodo1 { get; set; }
        public double? Periodo2 { get; set; }

        public virtual Alumno IdAlumnoNavigation { get; set; }
        public virtual Materia IdMateriaNavigation { get; set; }
    }
}
