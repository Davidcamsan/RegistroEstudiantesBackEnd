using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace RegistroEstudiantesBackEnd.Models
{
    public class Estudiante
    {
        public Estudiante()
        {
        }

        public string Nombre { get; set; }
        public int ID { get; set; }
        public string Foto { get; set; }
        public int Nota { get; set; }


        public static List<Estudiante> getAllStudents()
        {
            List<Estudiante> lstEstudiantes = new List<Estudiante>();

            lstEstudiantes.Add(new Estudiante { ID = 1, Nombre = "Carlos Dan", Nota = 70, Foto = "https://d30y9cdsu7xlg0.cloudfront.net/png/410776-200.png" });
            lstEstudiantes.Add(new Estudiante { ID = 1, Nombre = "Carla Dan", Nota = 70, Foto = "https://d30y9cdsu7xlg0.cloudfront.net/png/410776-200.png" });
            lstEstudiantes.Add(new Estudiante { ID = 1, Nombre = "Sun Dan", Nota = 70, Foto = "https://d30y9cdsu7xlg0.cloudfront.net/png/410776-200.png" });

            return lstEstudiantes;

        }
    }
}
