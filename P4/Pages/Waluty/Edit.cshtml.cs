using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using P4.Data;
using P4.Models;
using Newtonsoft.Json;
using System.Net.Http;

namespace P4.Pages.Waluty
{
    public class EditModel : PageModel
    {
        private readonly P4.Data.P4Context _context;

        public EditModel(P4.Data.P4Context context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            HttpClient client = new HttpClient();
            decimal mnoznik = 1;
            string zapytanko = ("https://openexchangerates.org/api/latest.json?app_id=0c4e952688494f94b916d6c2ef29a9ee&base=USD&symbols=" + waluty.Base);
            string json = await client.GetStringAsync(zapytanko);                //pobierz dane z API i zapisz je w zmiennej json
            walutesy_operacje rate = JsonConvert.DeserializeObject<walutesy_operacje>(json);      //deserializuj zawartość zmiennej json
            foreach (KeyValuePair<string, decimal> s in rate.rates)
                mnoznik = (1 / s.Value);

            zapytanko = ("https://openexchangerates.org/api/latest.json?app_id=0c4e952688494f94b916d6c2ef29a9ee&base=USD&symbols=" + waluty.Symbol);
            json = await client.GetStringAsync(zapytanko);
            rate = JsonConvert.DeserializeObject<walutesy_operacje>(json);
            foreach (KeyValuePair<string, decimal> s in rate.rates)
                waluty.wartosc = s.Value * mnoznik;

            waluty.dataPobrania = DateTime.Now;

            _context.Attach(waluty).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!walutyExists(waluty.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool walutyExists(int id)
        {
            return _context.waluty.Any(e => e.ID == id);
        }
    }
}
