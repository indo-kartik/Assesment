using System.ComponentModel.DataAnnotations;

namespace PayerAPI.Model
{
    public class PayerModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string PayerName { get; set; }
        
        
    }
}
