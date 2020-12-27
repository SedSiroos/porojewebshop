using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Poroject.Core.RegisterViewModel;
using Poroject.Core.Security;
using Poroject.Core.Services.InterFace;
using Poroject.DataLayer.Entities.User;

namespace Proje.Web.Pages.Admin.Roles
{
    [PermissionChecker(8)]
    public class EditeRolesModel : PageModel
    {
        private IPermissionService _permissionService;
        public EditeRolesModel(IPermissionService permissionService)
        {
            _permissionService = permissionService;
        }
        [BindProperty]
        public EditeRolesViewModel editeRolesViewModel { get; set; }
        
        public void OnGet(int id)
        {
            editeRolesViewModel = _permissionService.GetRoleForShowInEditMode(id);
            ViewData["permission"] = _permissionService.GetAllPermission();
            ViewData["Selectedpermission"] = _permissionService.SelectedPermissionsRole(id);
        }
        public IActionResult OnPost(int id,List<int> SelectedPermission)
        {
            if (!ModelState.IsValid)
                return Page();
            

            _permissionService.editRoles(editeRolesViewModel);
            _permissionService.UpdatePermissionRolle(id,SelectedPermission);

            return RedirectToPage("/Admin/Roles/Index");
        }
    }
}
