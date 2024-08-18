using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegistroGuia2._1.Models;

namespace RegistroGuia2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Departamento depa = new Departamento();
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            TomarDatos nacho = new TomarDatos();//creamos una ventana modal para tomar los datos.
            string dni = "";//declaramos variables para guardar los datos.
            string nombre = "";

            if(nacho.ShowDialog() == DialogResult.OK)//tomamos los datos de la ventana al recibir un .OK
            {
                dni = nacho.tbxDni.Text;
                nombre = nacho.tbxNombre.Text; 
            }

            Persona per = new Persona(dni, nombre);//creamos una instancia de la clase persona para guardar los datos que nos trae nacho.
            RegistroVehiculo reg = depa.RegistrarVehiculo(per);//llamamos al metodo registrarvehiculo de la clase departamento y le pasamos la persona.
            nacho.Dispose();                                  //y creamos un objeto de la clase registrovehiculo para recibir lo retornado por registrarV.
            tbxUltimo.Text = reg.VerDetalle();//mostrar en tbx los datos del objeto.           
        }   

        private void btnListrar_Click(object sender, EventArgs e)
        {
            for(int i = 0; i <depa.CantidadRegistrados; i++)//creamos un for para recorrer el arraylist e imprimir los registros cargados hasta el momento.
            {
                RegistroVehiculo val = depa.VerRegistro(i);
                lbxLista.Items.Add(val.VerDetalle());
            }
            
        }
    }
}
