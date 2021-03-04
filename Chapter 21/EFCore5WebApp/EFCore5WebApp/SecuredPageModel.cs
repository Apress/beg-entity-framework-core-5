using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace EFCore5WebApp
{
    public class SecuredPageModel : PageModel, IAsyncPageFilter
    {
        private readonly EFCOre5WebApp.DAL.AppDbContext _context;
        private SignInManager<IdentityUser> _signInManager;
        private UserManager<IdentityUser> _userManager;
        public bool IsAdminUser { get; set; }
        public bool IsViewOnlyUser { get; set; }
        public bool IsAllAllowedUser => IsAdminUser || IsViewOnlyUser;

        public SecuredPageModel(EFCOre5WebApp.DAL.AppDbContext context, SignInManager<IdentityUser> signInManager,
            UserManager<IdentityUser> userManager)
        {
            _context = context;
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public override async Task OnPageHandlerExecutionAsync(PageHandlerExecutingContext context,
                                                 PageHandlerExecutionDelegate next)
        {
            var userId = _userManager.GetUserId(User);
            var user = await _userManager.FindByIdAsync(userId);
            bool isSignedIn = _signInManager.IsSignedIn(User);
            IsAdminUser = isSignedIn && await _userManager.IsInRoleAsync(user, Roles.AdminRoleName);
            IsViewOnlyUser = isSignedIn && await _userManager.IsInRoleAsync(user, Roles.ViewOnlyRoleName);

            await next.Invoke();
        }
    }
}
