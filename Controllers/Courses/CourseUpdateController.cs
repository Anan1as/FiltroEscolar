using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FiltroEscolar.Models;
using FiltroEscolar.Services;

namespace FiltroEscolar.Controllers.Courses
{
    public class CourseUpdateController : ControllerBase
    {
        private readonly ICourseRepository _courseRepository;

        public CourseUpdateController(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        [HttpPut]
        [Route("/courses/{id}")]
        public Course Update(int id, [FromBody] Course course)
        {
            try
            {
                course.Id = id;
                _courseRepository.Update(course);
                return course;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}