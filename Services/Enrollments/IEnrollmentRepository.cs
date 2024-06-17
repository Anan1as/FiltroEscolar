using FiltroEscolar.Models;

namespace FiltroEscolar.Services
{
    public interface IEnrollmentRepository
    {
        IEnumerable<Enrollment> GetAll();
        IEnumerable<Enrollment> GetAllInDate(DateOnly date);
        Enrollment GetById(int id);
        void Create(Enrollment enrollment);
        void Update(Enrollment enrollment);
    }
}