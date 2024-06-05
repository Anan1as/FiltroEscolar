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
    public class EnrollmentRepository : IEnrollmentRepository
    {
        private readonly SchoolContext _context;

        public EnrollmentRepository(SchoolContext context)
        {
            _context = context;
        }

        public IEnumerable<Enrollment> GetAll()
        {
            return _context.Enrollments
            .Include(e => e.Student)
            .Include(e => e.Course)
                .ThenInclude(c => c.Teacher)
            .ToList();
        }

        public IEnumerable<Enrollment> GetAllInDate(DateOnly date)
        {
            return _context.Enrollments
            .Include(e => e.Student)
            .Include(e => e.Course)
                .ThenInclude(c => c.Teacher)
            .Where(e => e.Date == date)
            .ToList();
        }

        public Enrollment GetById(int id)
        {
            return _context.Enrollments
            .Include(e => e.Student)
            .Include(e => e.Course)
                .ThenInclude(c => c.Teacher)
            .FirstOrDefault(c => c.Id == id);
        }

        public void Create(Enrollment enrollment)
        {
            _context.Enrollments.Add(enrollment);
            _context.SaveChanges();
        }

        public void Update(Enrollment enrollment)
        {
            _context.Enrollments.Update(enrollment);
            _context.SaveChanges();
        }
    }
}