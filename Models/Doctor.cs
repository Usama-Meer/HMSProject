using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMSProject.Models
{
    public class Doctor
    {
        [Key]
        public int DoctorId { get; set; }
        [Required]
        public string DoctorName { get; set; }
        [Required]
        public string DoctorDescription { get; set; }
        [Required]
        public string Qualification { get; set; }
        [Required]
        public string Speciality { get; set; }
        [Required]
        public int Fee { get; set; }
        [Required]
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }

        public List<Appointment>? Appointments { get; set; }
    }
}
