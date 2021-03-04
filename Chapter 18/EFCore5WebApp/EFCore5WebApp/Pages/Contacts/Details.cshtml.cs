using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EFCore5WebApp.Core.Entities;

namespace EFCore5WebApp.Pages.Contacts
{
    public class DetailsModel : PageModel
    {
        private readonly EFCOre5WebApp.DAL.AppDbContext _context;

        public DetailsModel(EFCOre5WebApp.DAL.AppDbContext context)
        {
            _context = context;
        }

        public Person Person { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Person = await _context.Persons.Include(nameof(Person.Addresses)).FirstOrDefaultAsync(m => m.Id == id);

            if (Person == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
