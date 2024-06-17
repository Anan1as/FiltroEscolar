using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FiltroEscolar.Models;
using FiltroEscolar.Data;
using FiltroEscolar.Services;
using Microsoft.EntityFrameworkCore;

namespace FiltroEscolar.Services
{
    public class CourseRepository : ICourseRepository
    {
        private readonly SchoolContext _context;

        public CourseRepository(SchoolContext context)
        {
            _context = context;
        }

        public IEnumerable<Course> GetAll()
        {
            return _context.Courses
            .Include(c => c.Teacher)
            .ToList();
        }

        public Course GetById(int id)
        {
            return _context.Courses
            .Include(c => c.Teacher)
            .FirstOrDefault(c => c.Id == id);
        }

        public void Create(Course course)
        {
            _context.Courses.Add(course);
            _context.SaveChanges();
        }

        public void Update(Course course)
        {
            _context.Entry(course).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}