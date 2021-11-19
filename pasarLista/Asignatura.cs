using System;
using System.Collections.Generic;

namespace pasarLista
{
    public class Asignatura 
    {
        public string NombreAsignatura { get; set; }
        public string CodAsignatura { get; set; }
        public string CodProfesor { get; set; }
        //public List<Horario> misHorarios = new List<Horario>();
        //public string Hora { get; set; }
        public DateTime Fecha { get; set; }
        public List<AlumnoLista> misAlumnosEnAsignatura = new List<AlumnoLista>();


        public Asignatura(string n, string a, string e, DateTime f )//, List<AlumnoLista>al)//List<Horario>horarios)
        {
            this.NombreAsignatura = n;
            this.CodAsignatura = a;
            this.CodProfesor = e;
            //this.misHorarios = horarios;
            //this.Hora = h;
            this.Fecha = f;
            //this.misAlumnosEnAsignatura = al;
        }
        public Asignatura()
        {

        }

        public void addListaAlumno(List<AlumnoLista> alumnos)
        {
            misAlumnosEnAsignatura = alumnos;
        }
        
    }
}
