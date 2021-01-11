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
    public class IndexModel : PageModel
    {
        private readonly RazorPagesApplication.Data.RazorPagesApplicationContext _context;

        public IndexModel(RazorPagesApplication.Data.RazorPagesApplicationContext context)
        {
            _context = context;
        }

        public IList<Entry> Entry { get;set; }

        public async Task OnGetAsync()
        {
            Entry = await _context.Entry.ToListAsync();
        }
    }
}
