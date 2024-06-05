using FiltroEscolar.Models;

namespace FiltroEscolar.Services
{
    public interface ICourseRepository
    {
        IEnumerable<Course> GetAll();
        Course GetById(int id);
        void Create (Course course);
        void Update (Course course);
    }
}