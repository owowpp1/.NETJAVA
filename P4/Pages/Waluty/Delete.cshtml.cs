using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using P4.Data;
using P4.Models;

namespace P4.Pages.Waluty
{
    public class DeleteModel : PageModel
    {
        private readonly P4.Data.P4Context _context;

        public DeleteModel(P4.Data.P4Context context)
        {
            _context = context;
        }

        [BindProperty]
        public waluty waluty { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            waluty = await _context.waluty.FirstOrDefaultAsync(m => m.ID == id);

            if (waluty == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            waluty = await _context.waluty.FindAsync(id);

            if (waluty != null)
            {
                _context.waluty.Remove(waluty);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
