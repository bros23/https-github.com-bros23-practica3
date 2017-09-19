using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace practica2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void click( object sender, EventArgs e)
        {
            var nombre = txtNombre.Text;
            var apellidos = txtApellidos.Text;
            var direccion = txtDireccion.Text;
            var telefono = txttelefono.Text;
            var carrera = txtcarrera.Text;
            var semestre = txtsemestre.Text;
            var matricula = txtmatricula.Text;
            var correo = txtcorreo.Text;
            var github = txtgithub.Text;
            DisplayAlert("datos Ingresados ", nombre +"\n"+apellidos+"\n"+direccion+"\n"+telefono+"\n" +carrera+"\n" +semestre+"\n" +matricula+"\n" +correo+"\n" +github+"\n","Listo");
        }
    }
}
