using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Estudiantes_por_Asignatura
{
    // Clase base Estudiante
    public abstract class Estudiante
    {
        public string Nombre { get; set; }
        public string Matricula { get; set; }
        public double Nota { get; set; }

        public Estudiante(string nombre, string matricula)
        {
            Nombre = nombre;
            Matricula = matricula;
        }

        // metodo polimorfico
        public abstract void MostrarDatos();
    }
}
