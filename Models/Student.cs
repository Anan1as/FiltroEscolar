using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace FiltroEscolar.Models
{
    public class Student
    {
        public Student()
        {
            Enrollments = new List<Enrollment>();
        }

        public int Id { get; set; }

        [Required]
        public string? Names { get; set; }

        [Required]
        public DateOnly BirthDate { get; set; }

        [Required]
        public string? Address { get; set; }

        [Required]
        public string? Email { get; set; }

        public List<Enrollment>? Enrollments { get; set; }
    }
}