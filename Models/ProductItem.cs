using System.ComponentModel.DataAnnotations;

namespace HomeListsHelper.Models
{
    public class ProductItem
    {
        [Key]
        public Guid Id { get; set; }

        public Guid? CategoryId { get; set; }

        public string Name { get; set; }
        
        public string? Description { get; set; }
        
        public decimal? Amount { get; set; }
        
        public decimal? Weight { get; set; }
        
        public decimal? Price { get; set; }
    }
}
