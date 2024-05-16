using System.ComponentModel.DataAnnotations;

namespace HomeListsHelper.Models
{
    public class ItemsList
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string? Description { get; set; }

        public virtual ICollection<ProductItem> Items { get; set; }
    }
}
