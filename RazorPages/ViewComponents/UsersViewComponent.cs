using Microsoft.AspNetCore.Mvc;
using RazorPages.Services;
using System.Threading.Tasks;

namespace RazorPages.ViewComponents
{
    public class UsersViewComponent : ViewComponent
    {
        private readonly IUserService _userService;

        public UsersViewComponent(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var users = await _userService.GetUsersAsync();
            return View(users);
        }
    }
}