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
    public class TeacherRepository : ITeacherRepository
    {
        private readonly SchoolContext _context;

        public TeacherRepository(SchoolContext context)
        {
            _context = context;
        }

        public IEnumerable<Teacher> GetAll()
        {
            return _context.Teachers.ToList();
        }

        public Teacher GetWithAllCourses(int id)
        {
            return _context.Teachers
                .Include(t => t.Courses)
                .FirstOrDefault(t => t.Id == id);
        }

        public Teacher GetById(int id)
        {
            return _context.Teachers.Find(id);
        }

        public void Create(Teacher teacher)
        {
            _context.Teachers.Add(teacher);
            _context.SaveChanges();
        }

        public void Update(Teacher teacher)
        {
            _context.Entry(teacher).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}