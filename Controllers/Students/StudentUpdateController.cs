using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FiltroEscolar.Models;
using FiltroEscolar.Services;

namespace FiltroEscolar.Controllers.Students
{
    public class StudentUpdateController : ControllerBase
    {
        private readonly IStudentRepository _studentRepository;

        public StudentUpdateController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        [HttpPut]
        [Route("/students/{id}")]
        public Student Update(int id, [FromBody] Student student)
        {
            try
            {
                student.Id = id;
                _studentRepository.Update(student);
                return student;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}