using System.ComponentModel.DataAnnotations;

namespace Barang.Models
{
    public class Category
    {
        [Key]
        public Guid CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public int? SectionId { get; set; }
        public Section? Section { get; set; }
        public ICollection<Item> Items { get; set; }
    }
}
