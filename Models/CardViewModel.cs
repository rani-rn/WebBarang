namespace Barang.Models
{
    public class CardViewModel
    {
        public Guid ItemId { get; set; }
        public string? Title { get; set; }
        public string? BadgeText { get; set; }
        public string? ImageUrl { get; set; }
        public string? ImageAltText { get; set; }
        public string? Category { get; set; }

    }
}
