using System;
namespace pasarLista
{
    public class Profesor
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Codprof { get; set; }
        public string Login { get; set; }
        public string password { get; set; }

        public Profesor(string n, string a, string c, string login, string contra)
        {
            this.Nombre = n;
            this.Apellidos = a;
            this.Codprof = c;
            this.Login = login;
            this.password = contra;
        }
        public Profesor()
        {

        }
    }
}
