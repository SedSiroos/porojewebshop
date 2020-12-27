using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Poroject.Core.RegisterViewModel
{

    #region RegisterViewmodel
    public class RegisterViewModel
    {
        [Display(Name = "نام کاربری")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید.")]
        [MaxLength(100, ErrorMessage = "{1}نمیتواند بیشتر از {0}باشد.")]
        public string UserName { get; set; }

        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید.")]
        [MaxLength(200, ErrorMessage = "{1}نمیتواند بیشتر از {0}باشد.")]
        [EmailAddress(ErrorMessage = "ایمیل واردشده معتبر نیست")]
        public string Email { get; set; }

        [Display(Name = "کلمه عبور")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید.")]
        [MaxLength(200, ErrorMessage = "{1}نمیتواند بیشتر از {0}باشد.")]
        public string Password { get; set; }

        [Display(Name = "تکرارکلمه عبور")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید.")]
        [MaxLength(200, ErrorMessage = "{1}نمیتواند بیشتر از {0}باشد.")]
        [Compare("Password", ErrorMessage = "رمزعبور یکسان نمیباشد")]
        public string RePassword { get; set; }
    }
    #endregion

    #region LoginViewModel

    public class LoginViewModel
    {
        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید.")]
        [MaxLength(200, ErrorMessage = "{1}نمیتواند بیشتر از {0}باشد.")]
        [EmailAddress(ErrorMessage = "ایمیل واردشده معتبر نیست")]
        public string Email { get; set; }

        [Display(Name = "کلمه عبور")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید.")]
        [MaxLength(200, ErrorMessage = "{1}نمیتواند بیشتر از {0}باشد.")]
        public string Password { get; set; }

         [Display(Name = "مرابخاطر بسپار")]
        public bool RememberMe { get; set; }
    }
    #endregion

    #region ForgotPasswordViewModel
    public class ForgotPasswordViewModel
    {
        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید.")]
        [MaxLength(200, ErrorMessage = "{1}نمیتواند بیشتر از {0}باشد.")]
        [EmailAddress(ErrorMessage = "ایمیل واردشده معتبر نیست")]
        public string Email { get; set; }
    }
    #endregion

    #region ResetPassword
    public class ResetPasswordViewModel
    {
        
        public string ActiveCode { get; set; }

        [Display(Name = "کلمه عبور")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید.")]
        [MaxLength(200, ErrorMessage = "{1}نمیتواند بیشتر از {0}باشد.")]
        public string Password { get; set; }

        [Display(Name = "تکرارکلمه عبور")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید.")]
        [MaxLength(200, ErrorMessage = "{1}نمیتواند بیشتر از {0}باشد.")]
        [Compare("Password", ErrorMessage = "رمزعبور یکسان نمیباشد")]
        public string RePassword { get; set; }


        [Display(Name = "مرابخاطر بسپار")]
        public bool RememberMe { get; set; }
    }
    #endregion
}
