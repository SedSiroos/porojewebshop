using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Poroject.Core.RegisterViewModel;
using Poroject.Core.Services.InterFace;

namespace Proje.Web.Areas.UserPanel.Controllers
{
    [Area("UserPanel")]
    [Authorize]
    public class HomeController : Controller
    {
        private IUserService _userService;
        public HomeController(IUserService userService)
        {
            _userService = userService;
        }
        public IActionResult Index()
        {
            return View(_userService.GetUserInformation(User.Identity.Name));
        }


        #region Editeprofile
        [Route("UserPanel/EditeProfile")]
        public IActionResult EditeProfile()
        {
            return View(_userService.GetDataForEditeProfileUser(User.Identity.Name));
        }

        [Route("UserPanel/EditeProfile")]
        [HttpPost]
        public IActionResult EditeProfile(EditeProfileViewModel profileEdite)
        {
            if (!ModelState.IsValid)
                return View(profileEdite);

            _userService.EditProfile(User.Identity.Name,profileEdite);

            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return Redirect("/Login?EditProfile=true");
        }
        #endregion

        #region CHangePassword
        [Route("UserPanel/CHangePassword")]
        public IActionResult CHangePassword()
        {
            return View();
        }
        [Route("UserPanel/CHangePassword")]
        [HttpPost]
        public IActionResult CHangePassword(CHangePasswordViewModel changePass)
        {
            if (!ModelState.IsValid)
                return View(changePass);

            if (!_userService.CampairOldPasswordUser(changePass.OldPassword, User.Identity.Name))
            {
                ModelState.AddModelError("OldPassword", "کلمه عبور فعلی صحیح نمیباشد");
            }
            _userService.ChangePasswordUser(User.Identity.Name, changePass.Password);
            ViewBag.ChangePassword = true;
            return View();
        }
        #endregion
    }
}