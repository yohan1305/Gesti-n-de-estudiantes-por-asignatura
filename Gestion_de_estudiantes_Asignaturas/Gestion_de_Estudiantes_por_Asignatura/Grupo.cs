using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Estudiantes_por_Asignatura
{
    public class Grupo
    {
        public string NombreGrupo { get; set; }
        public List<Estudiante> Estudiantes { get; set; }

        public Grupo(string nombreGrupo)
        {
            NombreGrupo = nombreGrupo;
            Estudiantes = new List<Estudiante>();
        }

        public OperationResult AgregarEstudiante(Estudiante estudiante)
        {
            Estudiantes.Add(estudiante);
            return new OperationResult("Estudiante agregado correctamente", true, estudiante);
        }

        public OperationResult RegistrarNota(string matricula, double nota)
        {
            var estudiante = Estudiantes.Find(e => e.Matricula == matricula);
            if (estudiante != null)
            {
                estudiante.Nota = nota;
                return new OperationResult("Nota registrada correctamente", true, estudiante);
            }
            return new OperationResult("Estudiante no encontrado", false);
        }

        public void MostrarListado()
        {
            Console.WriteLine($"\nListado del grupo {NombreGrupo}:");
            foreach (var estudiante in Estudiantes)
            {
                estudiante.MostrarDatos();
            }
        }

        public double CalcularPorcentajeAprobados()
        {
            if (Estudiantes.Count == 0) return 0;
            int aprobados = 0;
            foreach (var estudiante in Estudiantes)
            {
                if (estudiante.Nota >= 70) aprobados++;
            }
            return (aprobados * 100.0) / Estudiantes.Count;
        }
    }

}
