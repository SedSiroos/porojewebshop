 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Poroject.Core.RegisterViewModel;
using Poroject.Core.Security;
using Poroject.Core.Services.InterFace;

namespace Proje.Web.Pages.Admin.Roles
{
    [PermissionChecker(7)]
    public class CreateRolesModel : PageModel
    {
        private IPermissionService _permissionService;
        public CreateRolesModel(IPermissionService permissionService)
        {
            _permissionService = permissionService;
        }
        [BindProperty]
        public CreateRolesViewModel createRolesViewModel { get; set; }
        public void OnGet()
        {
            ViewData["permission"] = _permissionService.GetAllPermission();
        }
        public IActionResult OnPost(List<int> SelectedPermission)
        {
            if (!ModelState.IsValid)
                return Page();

            int roleId=_permissionService.AddRolesForAdmin(createRolesViewModel);
            _permissionService.AddPermission(roleId, SelectedPermission);

            return RedirectToPage("Index");
        }
    }
}
