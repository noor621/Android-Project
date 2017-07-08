using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RestfulServiceForAndroidProject.Models;

namespace RestfulServiceForAndroidProject.Controllers
{
    
    public class StudentsController : ApiController
    {
        private MC_ProjectAssignerEntities db = new MC_ProjectAssignerEntities();

        public IEnumerable<Student> GetAllStudent()
        {
            var list = db.Students.ToList(); 
      
            return list;
        }

        [HttpPost]
        public IHttpActionResult InsertStudent(Student student)
        {
            
            db.Students.Add(student);
            db.SaveChangesAsync();
           
            return Ok(student.SEmailID);
        }
    }
}
