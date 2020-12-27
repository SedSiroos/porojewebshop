using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Poroject.Core.RegisterViewModel;
using Poroject.Core.Security;
using Poroject.Core.Services.InterFace;

namespace Proje.Web.Pages.Admin.Users
{
    [PermissionChecker(4)]
    public class EditUserModel : PageModel
    {
        private IUserService _userService;
        private IPermissionService _permissionService;
        public EditUserModel(IUserService userService, IPermissionService permissionService)
        {
            _userService = userService;
            _permissionService = permissionService;
        }



        [BindProperty]
        public EditeUserViewModel editeUserViewModel { get; set; }


        public void OnGet(int id)
        {
            editeUserViewModel = _userService.GetUserForShowInEditMode(id);
            ViewData["Roles"] = _permissionService.GetRoles();            
        }

        public IActionResult OnPost(List<int> SelectedRoles)
        {
            if (!ModelState.IsValid)
                return Page();

            _userService.EditeUserForAdmin(editeUserViewModel);

            _permissionService.EditeRoleUser(SelectedRoles, editeUserViewModel.UserId);

            return RedirectToPage("/Admin/Users/Index");
        }
    }
}
