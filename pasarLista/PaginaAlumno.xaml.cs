using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;

namespace pasarLista
{
    public partial class PaginaAlumno : ContentPage
    {
        Alumno a = new Alumno();
        List<Asignatura> asign = new List<Asignatura>();
        
        public PaginaAlumno(Alumno alumno, List<Asignatura> asignaturas)
        {
            InitializeComponent();
            a = alumno;
            asign = asignaturas;
            listaAsignaturas.ItemsSource = asignaturas;
        }
        
        async void objetosAsignatura_ItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            Asignatura aux = new Asignatura();
            aux = ((sender as ListView).SelectedItem as Asignatura);
            await Navigation.PushAsync(new PaginaContarAsistenciaAl(aux, a, asign));
        }
    }

   
}
