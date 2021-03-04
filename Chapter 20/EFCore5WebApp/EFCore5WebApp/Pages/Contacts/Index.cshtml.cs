using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EFCOre5WebApp.DAL;
using EFCore5WebApp.Core.Entities;

namespace EFCore5WebApp.Pages.Contacts
{
    public class IndexModel : PageModel
    {
        private readonly EFCOre5WebApp.DAL.AppDbContext _context;

        public IndexModel(EFCOre5WebApp.DAL.AppDbContext context)
        {
            _context = context;
        }

        public IList<Person> Person { get;set; }

        public async Task OnGetAsync()
        {
            Person = await _context.Persons.ToListAsync();
        }
    }
}
