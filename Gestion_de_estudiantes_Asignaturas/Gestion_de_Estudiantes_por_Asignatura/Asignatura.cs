using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Estudiantes_por_Asignatura
{
    public class Asignatura
    {
        public string NombreAsignatura { get; set; }
        public List<Grupo> Grupos { get; set; }

        public Asignatura(string nombreAsignatura)
        {
            NombreAsignatura = nombreAsignatura;
            Grupos = new List<Grupo>();
        }

        public void AgregarGrupo(Grupo grupo)
        {
            Grupos.Add(grupo);
        }
    }

}
