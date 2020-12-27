using Poroject.DataLayer.Entities.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Poroject.DataLayer.Entities.Wallet
{
    public class Wallet
    {
        public Wallet()
        {

        }
        [Key]
        public int WalletId { get; set; }

        [Display(Name = "نوع تراکنش")]
        [Required(ErrorMessage = "لطفا {0} را کامل کنید!!!")]
        public int TypeId { get; set; }

        [Display(Name = "کاربر")]
        [Required(ErrorMessage = "لطفا {0} را کامل کنید!!!")]
        public int UserId { get; set; }

        [Display(Name = "مبلغ")]
        [Required(ErrorMessage = "لطفا {0} را کامل کنید!!!")]
        public int Amount { get; set; }

        [Display(Name = " پرداخت تایید شده")]
        [Required(ErrorMessage = "لطفا {0} را کامل کنید!!!")]
        public bool IsPay { get; set; }

        [Display(Name = "توضیح")]
        [MaxLength(200, ErrorMessage = "{0}نمیتواند بیشتر از {1} کارکتر باشد!!")]
        public string Description { get; set; }

        [Display(Name = "تاریخ و ساعت")]
        [Required(ErrorMessage = "لطفا {0} را کامل کنید!!!")]
        public DateTime CreateDate { get; set; }




        #region Relation
        public virtual User.User user { get; set; }
        public virtual WalletType walletType { get; set; }
        #endregion
    }
}
