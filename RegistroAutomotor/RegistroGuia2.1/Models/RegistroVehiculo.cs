using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace RegistroGuia2._1.Models
{
   public class RegistroVehiculo
    {
        public string Patente { get; private set; }
        public string Serie { get; private set; }
        public Persona Propietario { get; private set; }
        public RegistroVehiculo(string patente, Persona propietario, string serie)//contructor de registrovehiculo, le damos estado inicial al objeto.
        {
            this.Patente = patente;
            this.Propietario = propietario;
            this.Serie = serie;
        }

        public string VerDetalle()
        {
            string datos = $"*Propietario:{Propietario.Nombre}\r\n *DNI:{Propietario.DNI}\r\n *Patente:{Patente}\r\n *Serie:{Serie}";
            return datos;                //de la propiedad "Propietario" accedemos al valor del atributo Nombre y DNI.//
        }
    }
}
