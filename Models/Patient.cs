using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMSProject.Models
{
    public class Patient
    {
        [Key]
        public int PatientId { get; set; }
        [Required]
        public string PatientName { get; set; }
        [Required]
        public DateTime Dob { get; set; }
        public string? Address { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string PatientEmail { get; set; }
        [Required]
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }

        public List<Appointment>? Appointments { get; set; }
    }
}
