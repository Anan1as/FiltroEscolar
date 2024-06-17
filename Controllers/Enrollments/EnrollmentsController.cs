using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FiltroEscolar.Models;
using FiltroEscolar.Services;

namespace FiltroEscolar.Controllers.Enrollments
{
    public class EnrollmentsController : ControllerBase
    {
        private readonly IEnrollmentRepository _enrollmentRepository;

        public EnrollmentsController(IEnrollmentRepository enrollmentRepository)
        {
            _enrollmentRepository = enrollmentRepository;
        }

        [HttpGet]
        [Route("/enrollments/")]
        public IEnumerable<Enrollment> GetAll()
        {
            try
            {
                return _enrollmentRepository.GetAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpGet]
        [Route("/enrollments/{date}/date")]
        public IEnumerable<Enrollment> GetAllInDate(DateOnly date)
        {
            try
            {
                return _enrollmentRepository.GetAllInDate(date);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        [HttpGet("{id}")]
        [Route ("/enrollments/{id}")]
        public Enrollment GetById(int id)
        {
            try
            {
                return _enrollmentRepository.GetById(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}