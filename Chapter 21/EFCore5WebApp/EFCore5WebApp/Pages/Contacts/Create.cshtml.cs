using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using EFCore5WebApp.Core.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace EFCore5WebApp.Pages.Contacts
{
    [Authorize(Roles =PageAccessRoles.AdminOnly)]
    public class CreateModel : SecuredPageModel
    {
        private readonly EFCOre5WebApp.DAL.AppDbContext _context;

        [BindProperty(SupportsGet = true)]
        public List<SelectListItem> States { get; set; }

        [BindProperty(SupportsGet = true)]
        public List<SelectListItem> Countries { get; set; }

        public CreateModel(EFCOre5WebApp.DAL.AppDbContext context, SignInManager<IdentityUser> signInManager,
            UserManager<IdentityUser> userManager) : base(context, signInManager, userManager)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            Person.Addresses.Add(new Address());

            States = _context.LookUps.Where(x => x.LookUpType == LookUpType.State).Select(x => new SelectListItem { Text = x.Description, Value = x.Code }).ToList();
            Countries = _context.LookUps.Where(x => x.LookUpType == LookUpType.Country).Select(x => new SelectListItem { Text = x.Description, Value = x.Code }).ToList();

            States.Insert(0, new SelectListItem { Text = "Select an item", Value = string.Empty });
            Countries.Insert(0, new SelectListItem { Text = "Select an item", Value = string.Empty });

            return Page();
        }

        [BindProperty(SupportsGet = true)]
        public Person Person { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Person.CreatedOn = DateTime.Now;
            _context.Persons.Add(Person);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
