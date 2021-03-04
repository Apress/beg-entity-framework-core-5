using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EFCore5WebApp.Core.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace EFCore5WebApp.Pages.Contacts
{

    [Authorize(Roles = PageAccessRoles.AllAccess)]
    public class DetailsModel : SecuredPageModel
    {
        private readonly EFCOre5WebApp.DAL.AppDbContext _context;

        public DetailsModel(EFCOre5WebApp.DAL.AppDbContext context, SignInManager<IdentityUser> signInManager,
            UserManager<IdentityUser> userManager) : base(context, signInManager, userManager)
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
