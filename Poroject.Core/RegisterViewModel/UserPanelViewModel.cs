using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Poroject.Core.RegisterViewModel
{

    #region InformationUserViewModel
    public class InformationUserViewModel
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public DateTime Registerdate { get; set; }
        public int Wallet { get; set; }
    }
    #endregion

    #region SidebarUserPanelViewModel
    public class SidebarUserPanelViewModel
    {
        public string UserName { get; set; }
        public DateTime Registerdate { get; set; }

        public string ImageName { get; set; }
    }
    #endregion

    #region EditeProfile
    public class EditeProfileViewModel 
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

        public IFormFile UserAvatar { get; set; }

        public string AvatarName { get; set; }
    }
    #endregion

    #region CHangePasswordViewModel
    public class CHangePasswordViewModel
    {
        [Display(Name = "کلمه عبور فعلی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید.")]
        [MaxLength(200, ErrorMessage = "{1}نمیتواند بیشتر از {0}باشد.")]     
        public string OldPassword { get; set; }

        [Display(Name = "کلمه عبورجدید")]
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
}
