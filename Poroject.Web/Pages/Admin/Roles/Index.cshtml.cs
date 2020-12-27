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
    [PermissionChecker(6)]
    public class IndexModel : PageModel
    {
        private IPermissionService _permissionService;
        public IndexModel(IPermissionService permissionService)
        {
            _permissionService = permissionService;
        }

        public List<Role> RoleList { get; set; }
        public void OnGet()
        {
            RoleList = _permissionService.GetRoles();   
        }
    }
}
