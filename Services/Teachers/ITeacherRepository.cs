using FiltroEscolar.Models;

namespace FiltroEscolar.Services
{
    public interface ITeacherRepository
    {
        IEnumerable<Teacher> GetAll();
        Teacher GetWithAllCourses(int id);
        Teacher GetById(int id);
        void Create (Teacher teacher);
        void Update (Teacher teacher);
    }
}