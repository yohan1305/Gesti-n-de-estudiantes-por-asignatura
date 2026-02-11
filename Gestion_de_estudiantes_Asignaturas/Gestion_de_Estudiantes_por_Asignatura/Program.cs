using Gestion_de_Estudiantes_por_Asignatura;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Gestión de Estudiantes por Asignatura ===");

        // Crear docente
        Docente docente = new Docente("Profesor Juan");

        // Crear asignatura y grupos
        Asignatura asignatura = new Asignatura("Programación I");
        Grupo grupoA = new Grupo("Grupo A");
        Grupo grupoB = new Grupo("Grupo B");
        asignatura.AgregarGrupo(grupoA);
        asignatura.AgregarGrupo(grupoB);
        docente.AgregarAsignatura(asignatura);

        // Agregar estudiantes al Grupo A
        grupoA.AgregarEstudiante(new EstudiantePresencial("Ana", "2024-001"));
        grupoA.AgregarEstudiante(new EstudianteDistancia("Luis", "2024-002"));
        grupoA.AgregarEstudiante(new EstudiantePresencial("María", "2024-003"));
        grupoA.AgregarEstudiante(new EstudianteDistancia("Pedro", "2024-004"));

        // Registrar notas en Grupo A
        grupoA.RegistrarNota("2024-001", 85);
        grupoA.RegistrarNota("2024-002", 65);
        grupoA.RegistrarNota("2024-003", 90);
        grupoA.RegistrarNota("2024-004", 72);

        // Mostrar listado Grupo A
        grupoA.MostrarListado();
        double porcentajeA = grupoA.CalcularPorcentajeAprobados();
        Console.WriteLine($"\nPorcentaje de aprobados en {grupoA.NombreGrupo}: {porcentajeA:F2}%");

        // Agregar estudiantes al Grupo B
        grupoB.AgregarEstudiante(new EstudiantePresencial("Carlos", "2024-005"));
        grupoB.AgregarEstudiante(new EstudianteDistancia("Sofía", "2024-006"));
        grupoB.AgregarEstudiante(new EstudiantePresencial("José", "2024-007"));

        // Registrar notas en Grupo B
        grupoB.RegistrarNota("2024-005", 55);
        grupoB.RegistrarNota("2024-006", 78);
        grupoB.RegistrarNota("2024-007", 88);

        // Mostrar listado Grupo B
        grupoB.MostrarListado();
        double porcentajeB = grupoB.CalcularPorcentajeAprobados();
        Console.WriteLine($"\nPorcentaje de aprobados en {grupoB.NombreGrupo}: {porcentajeB:F2}%");

        Console.WriteLine("\n=== Fin del reporte ===");
        Console.ReadKey();
    }
}

