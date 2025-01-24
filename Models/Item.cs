using System.ComponentModel.DataAnnotations;

namespace Barang.Models
{
    public class Item
    {
        [Key]
        public Guid ItemId { get; set; }

        public string? ItemName { get; set; }
        public int? ItemStock { get; set; }
        public bool? ItemStatus { get; set; }
        public string? ImagePath { get; set; }

        public Guid? CategoryId { get; set; }
        
        public Guid? SectionId { get; set; }
        
        public Category? Category { get; set; }
        
        public Section? Section { get; set; }
    }
}
