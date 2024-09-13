using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMSProject.Models
{
    public class Receiptionist
    {
        public int ReceiptionistId { get; set; }
        public string ReceiptionistName { get; set; }
        [Required]
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }

        public List<Appointment>? Appointments { get; set; }
    }
}
