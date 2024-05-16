using System.ComponentModel.DataAnnotations;

namespace HomeListsHelper.Models
{
    public class Category
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string? Description { get; set; }

        public virtual Guid? ParentId { get; set; }
    }
}
