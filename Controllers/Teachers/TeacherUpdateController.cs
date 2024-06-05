using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FiltroEscolar.Models;
using FiltroEscolar.Services;

namespace FiltroEscolar.Controllers.Teachers
{
    public class TeacherUpdateController : ControllerBase
    {
        private readonly ITeacherRepository _teacherRepository;

        public TeacherUpdateController(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }

        [HttpPut]
        [Route("/teachers/{id}")]
        public Teacher Update(int id, [FromBody] Teacher teacher)
        {
            try
            {
                teacher.Id = id;
                _teacherRepository.Update(teacher);
                return teacher;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}