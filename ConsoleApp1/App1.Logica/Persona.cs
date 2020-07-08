namespace App1.Logica
{
    public class Persona
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        private Celular celular;

        public Celular Celular {
            get { return celular; } 
            set { celular = value;
                celular.Propietario = this;
            } 
        }

        public Automovil Automovil { get; set; }

        public string Saludar()
        {
            return $"Hola, me llamo { Nombre } { Apellido } es un placer.";
        }
        public string IndicarCelular()
        {
            return $"Tengo un { Celular.Modelo }";
        }
    }
}
