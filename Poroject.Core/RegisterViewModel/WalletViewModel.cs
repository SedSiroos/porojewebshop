using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Poroject.Core.RegisterViewModel
{
    public class ChargeWalletViewModel
    {
        [Display(Name = "مبلغ")]
        [Required(ErrorMessage = "لطفا {0} را کامل کنید!!!")]
        public int Amount { get; set; }
    }

    public class WalletViewModel
    {
        public int Amount { get; set; }
        public int Type { get; set; }
        public DateTime CreateDate { get; set; }
        public string Description { get; set; }
    }
}
