using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace FiltroEscolar.Models
{
    public class Teacher
    {
        public Teacher()
        {
            Courses = new List<Course>();
        }

        public int Id { get; set; }

        [Required]
        public string? Names { get; set; }

        [Required]
        public string? Specialty { get; set; }

        [Required]
        public string? Phone { get; set; }

        [Required]
        public string? Email { get; set; }

        [Required]
        public int YearsExperience { get; set; }

        public List<Course>? Courses { get; set; }
    }
}