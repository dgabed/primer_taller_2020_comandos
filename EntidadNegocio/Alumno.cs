using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadNegocio
{
    class Alumno
    {
        public int id { get; set; }
        string nombre;
        string apellido;
        string direccion;
        string telefono;

        private List<Curso> cursos = new List<Curso>();

        public void agregarCurso(Curso c)
        {
            this.cursos.Add(c);
        }

        public List <Curso> GetCursos()
        {
            return this.cursos;
        }

    }
}
