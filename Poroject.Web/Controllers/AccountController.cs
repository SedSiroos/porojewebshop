using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Poroject.Core.Convertors;
using Poroject.Core.RegisterViewModel;
using Poroject.Core.Services.InterFace;
using Poroject.DataLayer.Entities.User;
using Poroject.Core.Generator;
using Poroject.Core.Security;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;


namespace Proje.Web.Controllers
{
    public class AccountController : Controller
    {
        private IUserService _userService;
        private IViewRenderService _viewRenderService;

        public AccountController(IUserService userService, IViewRenderService viewRenderService)
        {
            _userService = userService;
            _viewRenderService = viewRenderService;
        }


        #region Register
        [Route("Register")]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [Route("Register")]
        public IActionResult Register(RegisterViewModel register)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (_userService.IsExitUsername(register.UserName))
            {
                ModelState.AddModelError("UserName", "نام کاربری وجود دارد.");
                return View(register);
            }
            if (_userService.IsExitEmail(FixedText.FixedEmail(register.Email)))
            {
                ModelState.AddModelError("Email", "ایمیل ثبت شده است.");
                return View(register);
            }

            User user = new User()
            {
                ActiveCode = NameGenarator.GeneratorUniqCode(),
                Email = FixedText.FixedEmail(register.Email),
                Password = PasswordHelper.EncodePasswordMd5(register.Password),
                UserAvatar = "images.png",
                UserName = register.UserName,
                RegisterDate = DateTime.Now,
                Isactive = false,
            };
            _userService.Adduser(user);

 
            string bodyemail = _viewRenderService.RenderToStringAsync("_ActiveEmail", user);
            SendEmail.Send(user.Email, "فعال سازی", bodyemail);

            return View("SuccessRegister", user);
        }
        #endregion

        #region Login

        [Route("Login")]
        public IActionResult Login(bool EditProfile=false)
        {
            ViewBag.EditProfile = EditProfile;
            return View();
        }

        [HttpPost]
        [Route("Login")]
        public IActionResult Login(LoginViewModel login)
        {
            if (!ModelState.IsValid)
            {
                return View(login);
            }


            var user = _userService.LoginUser(login);
            if (user != null)
            {
                if (user.Isactive)
                {
                    var claims = new List<Claim>()
                    {
                        new Claim(ClaimTypes.NameIdentifier,user.UserId.ToString()),
                        new Claim(ClaimTypes.Name,user.UserName),
                    };
                    var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var principal = new ClaimsPrincipal(identity);

                    var properties = new AuthenticationProperties
                    {
                        IsPersistent = login.RememberMe
                    };
                    HttpContext.SignInAsync(principal, properties);

                    ViewBag.IsSuccess = true;
                    return View();
                }
                else
                {
                    ModelState.AddModelError("Email", "کاربری با مشخصات یافت نشد.");
                }
            }
            ModelState.AddModelError("Email", "کاربری با مشخصات یافت نشد.");
            return View(login);
        }


        #endregion   

        #region ActiveAccount
        public IActionResult ActiveAccount(string id)
        {
            ViewBag.IsActive = _userService.ActiveAccount(id);
            return View();
        }
        #endregion

        #region Logout
        [Route("Logout")]
        public IActionResult Logou()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Redirect("/");
        }
        #endregion

        #region ForgotPassword
        [Route("ForgotPassword")]
        public IActionResult ForgotPassword()
        {
            return View();
        }

        [Route("ForgotPassword")]
        [HttpPost]
        public IActionResult ForgotPassword(ForgotPasswordViewModel forgot)
        {
            if (!ModelState.IsValid)
            {
                return View(forgot);
            }

            string fixedEmail = FixedText.FixedEmail(forgot.Email);
            User user = _userService.getUserByEmail(fixedEmail);


            if (user == null)
            {
                ModelState.AddModelError("Email", "این ایمیل وجود ندارد");
                return View(forgot);
            }

            string bodyEmail = _viewRenderService.RenderToStringAsync("_ForgotPassword", user);
            SendEmail.Send(user.Email, "بازیابی کلمه عبور", bodyEmail);
            ViewBag.IsSuccess = true;
            return View();
        }
        #endregion

        #region ResetPassword
        [Route("ResetPassword")]
        public IActionResult ResetPassword(string id)
        {
            return View(new ResetPasswordViewModel()
            {
                ActiveCode = id
            });
        }
        [Route("ResetPassword")]
        [HttpPost]
        public IActionResult ResetPassword(ResetPasswordViewModel resetPass)
        {
            if (!ModelState.IsValid)
            {
                return View(resetPass);
            }

            var user = _userService.getUserByActiveCode(resetPass.ActiveCode);
            if (user == null)
            {
                return NotFound();
            }
            var newpassHash = PasswordHelper.EncodePasswordMd5(resetPass.Password);
            user.Password = newpassHash;
            _userService.Update(user);

            return Redirect("/Login");
        }
        #endregion
    }
}
   