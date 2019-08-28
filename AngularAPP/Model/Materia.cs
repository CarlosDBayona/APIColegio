using System;
using System.Collections.Generic;

namespace TaskColegio.Model
{
    public partial class Materia
    {
        public Materia()
        {
            Curso = new HashSet<Curso>();
        }

        public string IdMateria { get; set; }
        public string IdProfesor { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Curso> Curso { get; set; }
    }
}
