using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Estudiantes_por_Asignatura
{
    public class EstudianteDistancia : Estudiante
    {
        public EstudianteDistancia(string nombre, string matricula) : base(nombre, matricula) { }
        public override void MostrarDatos()
        {
            Console.WriteLine($"[Distancia] {Nombre} - Matricula: {Matricula} - Nota: {Nota}");
        }
    }
}
