using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Orai;

namespace Orai.Pages
{
    public class UjjMeccsModel : PageModel
    {
        private readonly Orai.FociDbContext _context;

        public UjjMeccsModel(Orai.FociDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Meccs Meccs { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Meccsek.Add(Meccs);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
