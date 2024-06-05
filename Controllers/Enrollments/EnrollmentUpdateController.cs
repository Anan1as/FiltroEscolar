using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FiltroEscolar.Models;
using FiltroEscolar.Services;

namespace FiltroEscolar.Controllers.Enrollments
{
    public class EnrollmentUpdateController : ControllerBase
    {
        private readonly IEnrollmentRepository _enrollmentRepository;

        public EnrollmentUpdateController(IEnrollmentRepository enrollmentRepository)
        {
            _enrollmentRepository = enrollmentRepository;
        }

        [HttpPut]
        [Route("/enrollments/{id}")]
        public Enrollment Update(int id, [FromBody] Enrollment enrollment)
        {
            try
            {
                enrollment.Id = id;
                _enrollmentRepository.Update(enrollment);
                return enrollment;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}