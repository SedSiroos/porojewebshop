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
    [PermissionChecker(2)]
    public class IndexModel : PageModel
    {       
        private IUserService _userService;
        public IndexModel(IUserService userService)
        {
            _userService = userService;
        }
        public UserForAdminViewModel userForAdminViewModl { get; set; }

        public void OnGet(int pageId = 1, string filterEmail = "", string filterUserName = "")
        {
            userForAdminViewModl = _userService.GetUserAdim(pageId, filterEmail, filterUserName);
        }
    }
}
