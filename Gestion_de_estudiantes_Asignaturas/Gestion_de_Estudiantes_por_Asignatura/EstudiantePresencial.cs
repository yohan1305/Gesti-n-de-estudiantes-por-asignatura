using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Estudiantes_por_Asignatura
{
    // Estudiante presencial

    public class EstudiantePresencial : Estudiante
    {
        public EstudiantePresencial(string nombre, string matricula) : base(nombre, matricula) { }

        public override void MostrarDatos()
        {
            Console.WriteLine($"[Presencial] {Nombre} - Matricula: {Matricula} - Nota: {Nota}");
        }
    }

}
