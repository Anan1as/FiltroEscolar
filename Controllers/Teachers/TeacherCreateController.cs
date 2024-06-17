using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FiltroEscolar.Models;
using FiltroEscolar.Services;

namespace FiltroEscolar.Controllers.Teachers
{
    public class TeacherCreateController : ControllerBase
    {
        private readonly ITeacherRepository _teacherRepository;

        public TeacherCreateController(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }

        [HttpPost]
        [Route("/teachers/")]
        public Teacher Create([FromBody] Teacher teacher)
        {
            try
            {
                _teacherRepository.Create(teacher);
                return teacher;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}