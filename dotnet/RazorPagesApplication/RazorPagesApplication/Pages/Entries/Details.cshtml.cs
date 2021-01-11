using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesApplication.Data;
using RazorPagesApplication.Models;

namespace RazorPagesApplication.Pages.Entries
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesApplication.Data.RazorPagesApplicationContext _context;

        public DetailsModel(RazorPagesApplication.Data.RazorPagesApplicationContext context)
        {
            _context = context;
        }

        public Entry Entry { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Entry = await _context.Entry.FirstOrDefaultAsync(m => m.ID == id);

            if (Entry == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
