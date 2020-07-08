using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Logica
{
    public class GeneradorAutomaticoDeIdentificacion
    {
        readonly Random random = new Random();

        public int Id { get; set; }

        public GeneradorAutomaticoDeIdentificacion()
        {
            Id = random.Next();
        }
    }
}
