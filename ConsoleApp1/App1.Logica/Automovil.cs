namespace App1.Logica
{
    public class Automovil : GeneradorAutomaticoDeIdentificacion
    {

        public string Modelo { get; set; }

        public string Marca { get; set; }

        public float Consumo { get; set; }

        public Persona Propietario { get; set; }

        public string Placa { get; set; }

        public Automovil() : base ()
        {

        }

    }
}
