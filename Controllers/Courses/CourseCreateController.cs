using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FiltroEscolar.Models;
using FiltroEscolar.Services;

namespace FiltroEscolar.Controllers.Courses
{
    public class CourseCreateController : ControllerBase
    {
        private readonly ICourseRepository _courseRepository;

        public CourseCreateController(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        [HttpPost]
        [Route("/courses/")]
        public Course Create([FromBody] Course course)
        {
            try
            {
                _courseRepository.Create(course);
                return course;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}