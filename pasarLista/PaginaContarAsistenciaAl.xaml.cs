using System;
using System.Collections.Generic;

using Xamarin.Forms;
using ZXing.Net.Mobile.Forms;

namespace pasarLista
{
    public partial class PaginaContarAsistenciaAl : ContentPage
    {
        ZXingBarcodeImageView qr;
        Asignatura a = new Asignatura();
        Alumno al = new Alumno();
        List<Asignatura> asigna = new List<Asignatura>();
        public PaginaContarAsistenciaAl(Asignatura asignatura, Alumno alumno, List<Asignatura> asignaturas)
        {
            InitializeComponent();
            a = asignatura;
            al = alumno;
            asigna = asignaturas;
            EtiquetaNombre.Text = Convert.ToString(a.NombreAsignatura);
            EtiquetaFecha.Text = Convert.ToString(a.Fecha);
        }

        async void BotonPasarLista_Clicked(System.Object sender, System.EventArgs e)
        {
            /*
            for(int i = 0; i < a.misAlumnosEnAsignatura.Count; i++)
            {
                if (a.misAlumnosEnAsignatura[i].Expediente.CompareTo(al.Expediente) == 0)
                {
                    a.misAlumnosEnAsignatura[i].Asistencia = true;
                }
            }
            */
            for(int i = 0; i < asigna.Count; i++)
            {
                if(asigna[i].Fecha.CompareTo(a.Fecha) == 0)
                {
                    for(int j = 0; j < a.misAlumnosEnAsignatura.Count; j++)
                    {
                        if(a.misAlumnosEnAsignatura[j].Expediente.CompareTo(al.Expediente) == 0)
                        {
                            a.misAlumnosEnAsignatura[j].Color = Color.Green;
                        }
                    }
                }
            }
            await Navigation.PushAsync(new FichaAlumno(al));
            
        }

        void ButtonQR_Clicked(System.Object sender, System.EventArgs e)
        {
            qr = new ZXingBarcodeImageView
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand

            };
            qr.BarcodeFormat = ZXing.BarcodeFormat.QR_CODE;
            qr.BarcodeOptions.Height = 500;
            qr.BarcodeOptions.Width = 500;
            qr.BarcodeValue = " https://www.youtube.com/watch?v=dQw4w9WgXcQ"; //AQUI IMPLEMENTAR COD ALUMNO

            asistencia_qr.Children.Add(qr);
            
            ButtonQR.IsEnabled = false;

            for (int i = 0; i < asigna.Count; i++)
            {
                if (asigna[i].Fecha.CompareTo(a.Fecha) == 0)
                {
                    for (int j = 0; j < a.misAlumnosEnAsignatura.Count; j++)
                    {
                        if (a.misAlumnosEnAsignatura[j].Expediente.CompareTo(al.Expediente) == 0)
                        {
                            a.misAlumnosEnAsignatura[j].Color = Color.Green;
                        }
                    }
                }
            }
        }
    }
}
