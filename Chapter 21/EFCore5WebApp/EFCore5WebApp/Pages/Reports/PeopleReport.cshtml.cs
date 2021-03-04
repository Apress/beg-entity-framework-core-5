using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EFCore5WebApp.Core.Entities;
using EFCore5WebApp.DAL;

namespace EFCore5WebApp.Pages.Reports
{
    public class PeopleReportModel : PageModel
    {
        private readonly EFCOre5WebApp.DAL.AppDbContext _context;

        public PaginatedList<Person> ReportData { get; set; }

        public PeopleReportModel(EFCOre5WebApp.DAL.AppDbContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync(int? pageIndex)
        {
            int pageSize = 10;

            var persons = from p in _context.Persons
                          orderby p.LastName, p.FirstName
                          select p;

            ReportData = await PaginatedList<Person>.CreateAsync(
                persons, pageIndex ?? 1, pageSize);
        }
    }
}