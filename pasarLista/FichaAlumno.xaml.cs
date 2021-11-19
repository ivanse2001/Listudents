using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace pasarLista
{
    public partial class FichaAlumno : ContentPage
    {
        Alumno al = new Alumno();
        public FichaAlumno(Alumno alumno)
        {
            InitializeComponent();
            al = alumno;
            NombreAl.Text = al.Nombre;
            ApellidosAl.Text = al.Apellidos;
            ExpedienteAl.Text = al.Expediente;
        }
    }
}
