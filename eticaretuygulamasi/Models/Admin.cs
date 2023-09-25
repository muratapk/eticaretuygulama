using System.ComponentModel.DataAnnotations;

namespace eticaretuygulamasi.Models
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }
        public string users { get; set; }
        public string pass { get; set; }
    }
}
