using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroGuia2._1.Models
{
   public class Persona
    {
        public string DNI { get; private set; }
        public string Nombre { get; private set; }

        public Persona(string dni, string nombre)
        {
            this.DNI = dni;
            this.Nombre = nombre;
        }
    }
}
