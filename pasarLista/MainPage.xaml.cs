using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace pasarLista
{
    public partial class MainPage : ContentPage
    {
        List<Alumno> misAlumnos = new List<Alumno>();
        List<Profesor> misProfesores = new List<Profesor>();
        List<Asignatura> asignaturas = new List<Asignatura>();
        
        public MainPage()
        {

            InitializeComponent();
            
            misAlumnos.Add(new Alumno("Rubén", "Picado García", "88767", "rubenpicado","rpicado"));
            misAlumnos.Add(new Alumno("Iván", "Castillo Villanueva", "23443", "ivancastillo", "icastillo"));
            misAlumnos.Add(new Alumno("Mario", "Quijada García", "66554", "marioquijada", "mquijada"));
            misAlumnos.Add(new Alumno("Rodrigo", "Álvarez Martín", "99089", "rodrigoalvarez", "ralvarez"));
            misAlumnos.Add(new Alumno("Ignacio", "Salgado Sánchez", "88765", "ignaciosalgado", "isalgado"));
            misAlumnos.Add(new Alumno("Roberto", "Jiménez Martín", "32415", "robertojimenez", "rjimenez"));
            misAlumnos.Add(new Alumno("Ernesto", "Álvarez Sánchez", "65489", "ernestoalvarez", "ealvarez"));
            misAlumnos.Add(new Alumno("Mario", "Rodríguez Alonso", "87600", "mariorodriguez", "mrodriguez"));
            misAlumnos.Add(new Alumno("Manuel", "Cañada Martin", "49081", "manuelcañada", "mcañada"));
            misAlumnos.Add(new Alumno("Jorge", "García Álvarez", "29082", "jorgegarcia", "jgarcia"));
            misAlumnos.Add(new Alumno("Evaristo", "Martín Martín", "19081", "evaristomartin", "emartin"));
            

            misProfesores.Add(new Profesor("Manuel", "Martín Merino", "12345", "manuelmartin", "mmartin"));
            misProfesores.Add(new Profesor("Roberto", "Berjón Mejías", "23456", "robertoberjon", "rberjon"));

            asignaturas.Add(new Asignatura("Álgebra. Grupo I", "09876", "12345", new DateTime(2021, 11, 2, 8, 30, 00)));//, alumnos1));
            asignaturas.Add(new Asignatura("Álgebra. Grupo II", "09876", "12345", new DateTime(2021, 11, 7, 12, 40, 00)));//, alumnos1));
            asignaturas.Add(new Asignatura("Física. Grupo I", "98763", "12345", new DateTime(2021, 11, 5, 10, 30, 00)));//, alumnos2));
            asignaturas.Add(new Asignatura("Física. Grupo II", "98763", "12345", new DateTime(2021, 11, 10, 10, 15, 00)));//, alumnos3));
            asignaturas.Add(new Asignatura("Bases de Datos II", "98761", "23456", new DateTime(2021, 11, 16, 10, 15, 00)));//, alumnos4));
            asignaturas.Add(new Asignatura("Programación. Grupo I", "98762", "23456", new DateTime(2021, 11, 18, 12, 45, 00)));//, alumnos5));
            asignaturas.Add(new Asignatura("Programación. Grupo II", "98762", "23456", new DateTime(2021, 11, 20, 13, 00, 00)));//, alumnos5));
            
            for (int i = 0; i < misAlumnos.Count; i++)
            {
                for(int j = 0; j < asignaturas.Count; j++)
                {
                    asignaturas[j].misAlumnosEnAsignatura.Add(new AlumnoLista(misAlumnos[i].Nombre, misAlumnos[i].Apellidos, misAlumnos[i].Expediente, Color.Red));
                }
            }


        }

        async void botonUser_Clicked(System.Object sender, System.EventArgs e)
        {
            int aux = 0;
            Alumno alu = new Alumno();
            Profesor prof = new Profesor();
            if(Login.Text != null)
            {
                if(Password.Text != null)
                {
                    for( int i = 0; i < misAlumnos.Count; i++)
                    {
                        if(Login.Text.CompareTo(misAlumnos[i].Login) == 0)
                        {
                            if(Password.Text.CompareTo(misAlumnos[i].Password) == 0)
                            {
                                aux = 1;
                                alu = misAlumnos[i];
                            }
                        }
                        
                    }
                    
                        for(int j = 0; j < misProfesores.Count; j++)
                        {
                            if(Login.Text.CompareTo(misProfesores[j].Login) == 0)
                            {
                                if(Password.Text.CompareTo(misProfesores[j].password) == 0)
                                {
                                    aux = 2;
                                    prof = misProfesores[j];
                                }
                            }
                        }
                    
                    if(aux == 1)
                    {
                        await Navigation.PushAsync(new PaginaAlumno(alu, asignaturas));
                    }
                    else if(aux == 2)
                    {
                        await Navigation.PushAsync(new PaginaProfesor(prof, asignaturas));
                    }
                }
                else
                {
                    await DisplayAlert("Cuidado", "No has introducido el Password", "ok");
                }
            }
            else
            {
                await DisplayAlert("Cuidado", "No has introducido el valor Login", "ok");
            }
        }
    }
}
