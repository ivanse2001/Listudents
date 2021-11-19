using System;
namespace pasarLista
{
    public class Alumno
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Expediente { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public Alumno(string n, string a, string e, string login, string contra)
        {
            this.Nombre = n;
            this.Apellidos = a;
            this.Expediente = e;
            this.Login = login;
            this.Password = contra;
        }
        public Alumno()
        {

        }
    }
}
