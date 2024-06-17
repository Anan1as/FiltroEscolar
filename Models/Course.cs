using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace FiltroEscolar.Models
{
    public class Course
    {
        public Course()
        {
            Enrollments = new List<Enrollment>();
        }

        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public string? Description { get; set; }

        [Required]
        public int? TeacherId { get; set; }

        [JsonIgnore]
        public Teacher? Teacher { get; set; }

        [Required]
        public string? Schedule { get; set; }

        [Required]
        public string? Duration { get; set; }

        [Required]
        public int Capacity { get; set; }

        [JsonIgnore]
        public List<Enrollment>? Enrollments { get; set; }
    }
}