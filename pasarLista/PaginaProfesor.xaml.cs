using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace pasarLista
{
    public partial class PaginaProfesor : ContentPage
    {
        Profesor p = new Profesor();
        List<Asignatura> asign = new List<Asignatura>();
        public PaginaProfesor(Profesor profesor, List<Asignatura> asignaturas)
        {
            InitializeComponent();
            p = profesor;
            //asign = asignaturas;
            for(int i = 0; i < asignaturas.Count; i++)
            {
                if(p.Codprof.CompareTo(asignaturas[i].CodProfesor) == 0)
                {
                    asign.Add(asignaturas[i]);
                }
            }
            if(asign.Count > 0)
            {
                listaAsignaturasProf.ItemsSource = asign;
            }
            
        }

        async void listaAsignaturasProf_ItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            Asignatura aux = new Asignatura();
            aux = ((sender as ListView).SelectedItem as Asignatura);
            await Navigation.PushAsync(new PaginaListaProfesor(aux));
        }
    }
}
