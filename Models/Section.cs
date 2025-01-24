using System.ComponentModel.DataAnnotations;

namespace Barang.Models
{
    public class Section
    {
        [Key]
        public Guid SectionId { get; set; }
        public string? SectionName { get; set; }
        
        public ICollection<Category> Categories { get; set; }
        
        
        public ICollection<Item> Items { get; set; }
    }
}
