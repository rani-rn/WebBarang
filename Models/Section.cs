using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Barang.Models
{
    public class Section
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
    
    }

    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public int SectionId { get; set; }

        
    }

    public class Item
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ItemId { get; set; }
        public string? ItemName { get; set; }
        public int ItemStock { get; set; }
        public bool status { get; set; }
        public int CategoryId { get; set; }
        public string? ImagePath { get; set; }

    }

}
