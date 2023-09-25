using System.ComponentModel.DataAnnotations;

namespace eticaretuygulamasi.Models
{
    public class Slayt
    {
        [Key]
        public int SlaytId { get; set; }
        public string Header { get; set; }
        public  string  Content { get; set; }
    }
}
