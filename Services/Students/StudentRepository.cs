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
    public class StudentRepository : IStudentRepository
    {
        private readonly SchoolContext _context;

        public StudentRepository(SchoolContext context)
        {
            _context = context;
        }

        public IEnumerable<Student> GetAll()
        {
            return _context.Students.ToList();
        }

        public IEnumerable<Student> GetAllByBirthday(DateOnly date)
        {
            return _context.Students.Where(s => s.BirthDate == date).ToList();
        }

        public Student GetWithAllEnrollments(int id)
        {
            return _context.Students
                .Include(s => s.Enrollments)
                    .ThenInclude(e => e.Course)
                        .ThenInclude(c => c.Teacher)
                .FirstOrDefault(s => s.Id == id);
        }

        public Student GetById(int id)
        {
            return _context.Students.Find(id);
        }

        public void Create(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
        }

        public void Update(Student student)
        {
            _context.Entry(student).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}