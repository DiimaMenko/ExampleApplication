﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using HomeListsHelper.Data;
using HomeListsHelper.Models;

namespace HomeListsHelper.Pages.ProductItems
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public CreateModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public ProductItem ProductItem { get; set; } = default!;


        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _context.ProductItem == null || ProductItem == null)
            {
                return Page();
            }

            _context.ProductItem.Add(ProductItem);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
