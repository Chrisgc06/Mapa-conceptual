using Mapa_conceptual;
using System;
using System.Collections.Generic;

namespace Mapa_conceptual
{ 
    class Program
    {
        static void Main(string[] args)
        {
            List<MiembroDeLaComunidad> comunidad = new List<MiembroDeLaComunidad>
            {
                new Estudiante("Carlos"),
                new ExAlumno("María"),
                new Empleado("Luis"),
                new Administrativo("Paula"),
                new Docente("Pedro"),
                new Maestro("Laura"),
                new Administrador("José")
            };

            Console.WriteLine("=== Información de la Comunidad Educativa ===\n");

            foreach (var persona in comunidad)
            {
                persona.MostrarInformacion();
            }
        }
    }
}