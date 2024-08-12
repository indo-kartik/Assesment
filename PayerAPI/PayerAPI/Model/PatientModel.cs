using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PayerAPI.Model
{
    public class PatientModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string PatientName { get; set; }
        [Required]
        public long age { get; set; }
        [Required]
        public string gender { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string ContactNumber { get; set; }
        public string MedicalHistory { get; set; }
        [Required]
        public string InsurenceNumber { get; set; }
        [Required]
        public long payerId { get; set; }

    }
}
