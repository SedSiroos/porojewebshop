using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Poroject.DataLayer.Entities.User
{
    public class User
    {
        public User()
        {

        }


        [Key]
        public int UserId { get; set; }

        [Display(Name = "نام کاربری")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید.")]
        [MaxLength(100, ErrorMessage = "{1}نمیتواند بیشتر از {0}باشد.")]
        public string UserName { get; set; }

         [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید.")]
        [MaxLength(200, ErrorMessage = "{1}نمیتواند بیشتر از {0}باشد.")]
        [EmailAddress(ErrorMessage ="ایمیل واردشده معتبر نیست")]
        public string Email { get; set; }

        [Display(Name = "کلمه عبور")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید.")]
        [MaxLength(200, ErrorMessage = "{1}نمیتواند بیشتر از {0}باشد.")]
        public string Password { get; set; }

        [Display(Name = "کد فعال سازی ")]
        [MaxLength(50, ErrorMessage = "{1}نمیتواند بیشتر از {0}باشد.")]
        public string ActiveCode{ get; set; }

        [Display(Name = "وضعیت")]
        public bool Isactive { get; set; }

        [Display(Name = "تاریخ ثبت نام")]
        public DateTime RegisterDate { get; set; }

        [Display(Name = "تصویر")]
        [MaxLength(200, ErrorMessage = "{1}نمیتواند بیشتر از {0}باشد.")]
        public string UserAvatar { get; set; }
        public bool IsDelete { get; set; }

        #region Relation
        public virtual List<UserRole> userRole { get; set; }
        public virtual List<Wallet.Wallet> wallet { get; set; }
        public virtual List<Course.Course> Courses { get; set; }
        #endregion
    }
}
