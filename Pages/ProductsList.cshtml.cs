using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HomeListsHelper.Models;

namespace HomeListsHelper.Pages
{
    public class ProductsListModel : PageModel
    {
        private readonly Data.ApplicationDbContext _context;

        public ProductsListModel(Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<ProductItem> ProductItem { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.ProductItem != null)
            {
                ProductItem = await _context.ProductItem.ToListAsync();
            }
        }
    }
}
