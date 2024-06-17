using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace FiltroEscolar.Models
{
    public class Enrollment
    {
        public int Id { get; set; }

        [Required]
        public DateOnly Date { get; set; }

        [Required]
        public int StudentId { get; set; }

        [JsonIgnore]
        public Student? Student { get; set; }

        [Required]
        public int CourseId { get; set; }

        public Course? Course { get; set; }

        public enum Status {
            [Display(Name = "Pagado")]
            Pagado,
            [Display(Name = "Pendiente de Pago")]
            PendienteDePago,
            [Display(Name = "Cancelada")]
            Cancelada
        }
    }
}