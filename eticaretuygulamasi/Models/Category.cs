using System.ComponentModel.DataAnnotations;

namespace eticaretuygulamasi.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string?  CategoryName { get; set; }

        public  virtual List<Product>? Procudts { get; set; }

    }
}
