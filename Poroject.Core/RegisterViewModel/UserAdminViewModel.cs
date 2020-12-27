using Microsoft.AspNetCore.Http;
using Poroject.DataLayer.Entities.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Poroject.Core.RegisterViewModel
{
    #region UserForAdminViewModel
    public class UserForAdminViewModel
    {
        public List<User> UsersAdmin { get; set; }
        public int CurrentPage { get; set; }
        public int PageCount { get; set; }
    }
    #endregion


    #region CreateUserViewModel
    public class CreateUserViewModel
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

        public IFormFile AvatarUser { get; set; }
        // public List<int> SelectedRoles { get; set; }
    }
    #endregion


    #region EditeUserViewModel
    public class EditeUserViewModel
    {
        public int UserId { get; set; }
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

        public bool IsActive { get; set; }
        public IFormFile AvatarUser { get; set; }
        public string AvatarName { get; set; }
        public List<int> userRoles { get; set; }

    }

    #endregion


    #region CreateRolesViewModel
    public class CreateRolesViewModel
    {
        [Display(Name = "عنوان نقش ")]
        [Required(ErrorMessage = "لطفا {0} را کامل کنید!!!")]
        public String RoleTitle { get; set; }
    }
    #endregion

    #region CreateRolesViewModel
    public class EditeRolesViewModel
    {
        public int RoleId { get; set; }

        [Display(Name = "عنوان نقش ")]
        [Required(ErrorMessage = "لطفا {0} را کامل کنید!!!")]
        public String RoleTitle { get; set; }
    }
    #endregion
}
