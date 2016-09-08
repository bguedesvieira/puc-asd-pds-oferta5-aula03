using CityServicesApi.Models;
using CityServicesApi.Data;
using CityServicesApi.Dto.v1;
using CityServicesApi.ApiException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CityServicesApi.Controllers.v1
{
    [RoutePrefix("api/{folder}/alunos")]
    public class StudentController : ApiController
    {
        private StudentRepository _studentRepository = new StudentRepository();

        [HttpGet]
        [Route("historico/{id}")]
        public IHttpActionResult GetStudentHistory(int id)
        {
            Student student = _studentRepository.GetStudent(id);
            if (student == null)
            {
                NotFound();
            }

            StudentHistoryResponse response = new StudentHistoryResponse();
            response.StudentId = student.Id;
            response.Subjects = new List<StudentSubject>();

            foreach (SubjectStudent sub in student.Subjects)
            {
                response.Subjects.Add(new StudentSubject { SubjectId = sub.Subject.Id, SubjectName = sub.Subject.Name, Grade = sub.Grade });
            }
            return Ok(response);
        }
    }
}
