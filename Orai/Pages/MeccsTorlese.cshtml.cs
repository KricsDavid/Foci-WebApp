﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Orai;

namespace Orai.Pages
{
    public class MeccsTorleseModel : PageModel
    {
        private readonly Orai.FociDbContext _context;

        public MeccsTorleseModel(Orai.FociDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Meccs Meccs { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var meccs = await _context.Meccsek.FirstOrDefaultAsync(m => m.Id == id);

            if (meccs == null)
            {
                return NotFound();
            }
            else
            {
                Meccs = meccs;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var meccs = await _context.Meccsek.FindAsync(id);
            if (meccs != null)
            {
                Meccs = meccs;
                _context.Meccsek.Remove(Meccs);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./MeccsekListaja");
        }
    }
}
