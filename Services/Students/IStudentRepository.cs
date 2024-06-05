using FiltroEscolar.Models;

namespace FiltroEscolar.Services
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAll();
        IEnumerable<Student> GetAllByBirthday(DateOnly date);
        Student GetWithAllEnrollments(int id);
        Student GetById(int id);
        void Create (Student student);
        void Update (Student student);
    }
}