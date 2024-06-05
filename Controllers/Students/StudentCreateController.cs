using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FiltroEscolar.Models;
using FiltroEscolar.Services;

namespace FiltroEscolar.Controllers.Students
{
    public class StudentCreateController : ControllerBase
    {
        private readonly IStudentRepository _studentRepository;

        public StudentCreateController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        [HttpPost]
        [Route("/students/")]
        public Student Create([FromBody] Student student)
        {
            try
            {
                _studentRepository.Create(student);
                return student;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}