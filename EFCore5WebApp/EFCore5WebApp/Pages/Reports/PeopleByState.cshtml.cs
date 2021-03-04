using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EFCOre5WebApp.DAL;
using EFCore5WebApp.Core.Entities;

namespace EFCore5WebApp.Pages.Reports
{
    public class PeopleByStateModel : PageModel
    {
        private readonly EFCOre5WebApp.DAL.AppDbContext _context;

        public class PersonByStateReportDto
        {
            public string State { get; set; }
            public IEnumerable<Person> People { get; set; }
        }

        public PeopleByStateModel(EFCOre5WebApp.DAL.AppDbContext context)
        {
            _context = context;
        }

        public IList<PersonByStateReportDto> ReportData { get;set; }

        public async Task OnGetAsync()
        {
            ReportData = (from a in await _context.Addresses.Include("Person").ToListAsync()
                          group a by a.State into g
                          orderby g.Key
                          select new PersonByStateReportDto { State = g.Key, People = g.Select(x => x.Person) }).ToList();

        }
    }
}
