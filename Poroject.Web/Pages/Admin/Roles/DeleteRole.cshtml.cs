using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Poroject.Core.Security;
using Poroject.Core.Services.InterFace;
using Poroject.DataLayer.Entities.User;

namespace Proje.Web.Pages.Admin.Roles
{
    [PermissionChecker(9)]
    public class DeleteRoleModel : PageModel
    {
        private IPermissionService _permissionService;
        public DeleteRoleModel(IPermissionService permissionService)
        {
            _permissionService = permissionService;
        }

        [BindProperty]
        public Role role { get; set; }
        public void OnGet(int id)
        {
            role = _permissionService.GetRolesById(id);
        }
        public IActionResult OnPost()
        {
            _permissionService.DeleteRole(role);
            return RedirectToPage("Index");
        }
    }
}
