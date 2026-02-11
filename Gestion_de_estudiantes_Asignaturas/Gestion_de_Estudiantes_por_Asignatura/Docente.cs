using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Estudiantes_por_Asignatura
{
    public class Docente
    {
        public string NombreDocente { get; set; }
        public List<Asignatura> Asignaturas { get; set; }

        public Docente(string nombreDocente)
        {
            NombreDocente = nombreDocente;
            Asignaturas = new List<Asignatura>();
        }

        public void AgregarAsignatura(Asignatura asignatura)
        {
            Asignaturas.Add(asignatura);
        }
    }

}
