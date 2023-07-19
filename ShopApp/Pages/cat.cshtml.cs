using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShopApp.Data;
using ShopApp.Models;

namespace ShopApp.Pages
{
    public class catModel : PageModel
    {
        private readonly ShopApp.Data.ShopAppDBContext _context;

        public catModel(ShopApp.Data.ShopAppDBContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CreatorId"] = new SelectList(_context.Users, "Id", "Email");
            return Page();
        }

        [BindProperty]
        public Category Category { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Categories == null || Category == null)
            {
                return Page();
            }

            _context.Categories.Add(Category);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
