using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HomeListsHelper.Data;
using HomeListsHelper.Models;

namespace HomeListsHelper.Pages.ProductItems
{
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public DeleteModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ProductItem ProductItem { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null || _context.ProductItem == null)
            {
                return NotFound();
            }

            var productitem = await _context.ProductItem.FirstOrDefaultAsync(m => m.Id == id);

            if (productitem == null)
            {
                return NotFound();
            }
            else
            {
                ProductItem = productitem;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(Guid? id)
        {
            if (id == null || _context.ProductItem == null)
            {
                return NotFound();
            }
            var productitem = await _context.ProductItem.FindAsync(id);

            if (productitem != null)
            {
                ProductItem = productitem;
                _context.ProductItem.Remove(ProductItem);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
