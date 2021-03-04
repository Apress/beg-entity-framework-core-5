using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EFCore5WebApp.Core.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace EFCore5WebApp.Pages.Contacts
{
    [Authorize(Roles = PageAccessRoles.AllAccess)]
    public class IndexModel : SecuredPageModel
    {
        private readonly EFCOre5WebApp.DAL.AppDbContext _context;

        public IndexModel(EFCOre5WebApp.DAL.AppDbContext context, SignInManager<IdentityUser> signInManager,
            UserManager<IdentityUser> userManager) : base(context, signInManager, userManager)
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
