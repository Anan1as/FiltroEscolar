using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FiltroEscolar.Models;
using FiltroEscolar.Services;

namespace FiltroEscolar.Controllers.Courses
{
    public class CoursesController : ControllerBase
    {
        private readonly ICourseRepository _courseRepository;

        public CoursesController(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        [HttpGet]
        [Route("/courses/")]
        public IEnumerable<Course> GetAll()
        {
            try
            {
                return _courseRepository.GetAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpGet("{id}")]
        [Route ("/courses/{id}")]
        public Course GetById(int id)
        {
            try
            {
                return _courseRepository.GetById(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}