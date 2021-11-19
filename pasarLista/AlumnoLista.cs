using System;
using Xamarin.Forms;

namespace pasarLista
{
    public class AlumnoLista
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Expediente { get; set; }
        public Color Color { get; set; }

        public AlumnoLista(string n, string a, string e, Color color)
        {
            this.Nombre = n;
            this.Apellidos = a;
            this.Expediente = e;
            this.Color = color;
        }
        public AlumnoLista()
        {
            
        }
    }
}
