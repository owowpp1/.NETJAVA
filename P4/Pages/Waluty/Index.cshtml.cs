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
    public class IndexModel : PageModel
    {
        private readonly P4.Data.P4Context _context;

        public IndexModel(P4.Data.P4Context context)
        {
            _context = context;
        }

        public IList<waluty> waluty { get;set; }

        public async Task OnGetAsync()
        {
            waluty = await _context.waluty.ToListAsync();
        }
    }
}
