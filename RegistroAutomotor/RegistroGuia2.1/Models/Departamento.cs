using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace RegistroGuia2._1.Models
{
   public class Departamento
    {
        public int CantidadRegistrados 
        { get { return registro.Count; } }
        ArrayList registro = new ArrayList();//representa la composicion.
        #region Metodos
        Random letra = new Random();//creo un obj de tipo  random para el tema de letras.
        int numReg = 0;
        int numSerie = 0;
        public RegistroVehiculo  RegistrarVehiculo(Persona propietario)//retornamos un obj de la clase registro
        {                                                             //para despues mostrarlo en el tbx.
            string paten = GenerarPatente();
            string serie = GenerarSerie();
            RegistroVehiculo regi = new RegistroVehiculo(paten, propietario, serie);//se crea el obj y le pasamos los valores atrvez del contructor.
            registro.Add(regi);//agregamos un obj registro al arraylist.
            return regi;
        }
        public RegistroVehiculo VerRegistro(int idx)//buscamos en el arraylist un objeto registro en base al idx.
        {
            
                if(idx >= 0 && idx < CantidadRegistrados)//si idx es mayor a 0 y menor a la cantidad de registros.
                {
                  return registro[idx] as RegistroVehiculo;//hacemos un casteo para que nos devuelva u objeto de tipo registrovehiculo.
                }
            return null;
           
        }
        private string GenerarPatente()
        {
            int nroCarac = letra.Next(100);

            char C1 = (char)letra.Next((int)'A', (int)'Z' + 1);//como generar letras aleatorias.
            char C2 = (char)letra.Next((int)'A', (int)'Z' + 1);//cada letra tiene un numero, el char si lo casteas te da ese numero
                                                               //siendo numero es facil generar letras aleatorias.

            string chinomandarin = $"{C1}{C2}{numReg++:000}";
            return chinomandarin;
        }
        private string GenerarSerie()
        {
            string numSerie = $"{this.numSerie++:000}";
            return numSerie;
        }
        #endregion
    }

    
}
