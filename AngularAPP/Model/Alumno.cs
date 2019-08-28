using System;
using System.Collections.Generic;

namespace TaskColegio.Model
{
    public partial class Alumno
    {
        public Alumno()
        {
            Curso = new HashSet<Curso>();
        }

        public string Apellido { get; set; }
        public string Id { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Curso> Curso { get; set; }
    }
}
