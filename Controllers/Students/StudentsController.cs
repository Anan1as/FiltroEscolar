using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FiltroEscolar.Models;
using FiltroEscolar.Services;

namespace FiltroEscolar.Controllers.Students
{
    public class StudentsController : ControllerBase
    {
        private readonly IStudentRepository _studentRepository;

        public StudentsController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        [HttpGet]
        [Route("/students/")]
        public IEnumerable<Student> GetAll()
        {
            try
            {
                return _studentRepository.GetAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpGet]
        [Route("/students/{date}/birthday")]
        public IEnumerable<Student> GetAllByBirthday(DateOnly date)
        {
            try
            {
                return _studentRepository.GetAllByBirthday(date);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpGet]
        [Route ("/students/{id}/enrollments")]
        public Student GetWithAllEnrollments(int id)
        {
            try
            {
                return _studentRepository.GetWithAllEnrollments(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpGet("{id}")]
        [Route ("/students/{id}")]
        public Student GetById(int id)
        {
            try
            {
                return _studentRepository.GetById(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}