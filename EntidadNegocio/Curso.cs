using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadNegocio
{
    class Curso
    {
        private string descripcion;
        private Alumno alumno;

        public void setAlumno(Alumno a)
        {
            this.alumno = a;
        }

        public Alumno getAlumno()
        {
            return this.alumno;
        }
    }
}
