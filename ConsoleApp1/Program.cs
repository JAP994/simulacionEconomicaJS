using System;
using App1.Logica;

namespace ConsoleApp1
{
    class Program
    {
        static readonly Random random = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var empresa = new Empresa()
            {
                Id = random.Next(),

            };

            var estudiante = new Persona
            {
                Id = random.Next(),
                Nombre = "Steven",
                Apellido = "Chavez",
                Celular = empresa.ConstruirCelular("Samsung")
            };
            estudiante.Automovil = empresa.ConstruirAutomovil("Sandero");

            Console.WriteLine(estudiante.Saludar());
            Console.WriteLine(estudiante.IndicarCelular());

            Console.ReadKey();
        }
    }
}
