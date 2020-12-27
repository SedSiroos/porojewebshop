using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Poroject.Core.RegisterViewModel;
using Poroject.Core.Services.InterFace;

namespace Proje.Web.Pages.Admin.Users
{
    public class ListDeleteUsersModel : PageModel
    {
        private IUserService _userService;
        public ListDeleteUsersModel(IUserService userService)
        {
            _userService = userService;
        }

        [BindProperty]
        public UserForAdminViewModel userForAdminViewModl { get; set; }

        public void OnGet(int pageId= 1,string filterUserName = "",string filterEmail="")
        {
            userForAdminViewModl = _userService.GetDeleteUserByAdmin(pageId, filterUserName, filterEmail);
        }   
    }
}
