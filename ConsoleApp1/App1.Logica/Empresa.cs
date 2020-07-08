using System;

namespace App1.Logica
{
    public class Empresa
    {
        readonly Random random = new Random();

        public int Id { get; set; }

        public string Nombre { get; set; }

        public Celular ConstruirCelular(string modelo) 
        {
            //Materias primas?
            //Desperdicios?

            return new Celular() {
                Id = random.Next(),
                Marca = Nombre,
                Modelo = modelo
            };
        }
        public Automovil ConstruirAutomovil(string modelo) 
        {
            //Materias primas?
            //Desperdicios?

            return new Automovil()
            {
                Marca = Nombre,
                Modelo = modelo
            };
        }
    }
}
