using System;
namespace pasarLista
{
    public class Horario
    {
        public string NombreAsig { get; set; }
        public string Hora { get; set; }
        


        public Horario(string n, string h)
        {
            this.NombreAsig = n;
            this.Hora = h;
            
        }
        public Horario()
        {

        }
    }
}
