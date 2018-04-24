using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RegistroEstudiantesBackEnd.Models;
using Newtonsoft.Json; 

namespace RegistroEstudiantesBackEnd.Controllers
{
    public class EstudianteController : Controller
    {
        public ActionResult Index()
        {
            return View ();
        }

        public string GetAllStudents(){

            List<Estudiante> lstEstudiantes = Estudiante.getAllStudents();

            return JsonConvert.SerializeObject(lstEstudiantes);
        }
    }
}
