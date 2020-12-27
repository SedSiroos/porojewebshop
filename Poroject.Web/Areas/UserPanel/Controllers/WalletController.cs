using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Poroject.Core.RegisterViewModel;
using Poroject.Core.Services.InterFace;

namespace Proje.Web.Areas.UserPanel.Controllers
{
    [Area("UserPanel")]
    [Authorize]
    public class WalletController : Controller
    {
        private IUserService _userService;
        public WalletController(IUserService userService)
        {
            _userService = userService;
        }

        [Route("UserPanel/Wallet")]
        public IActionResult Index()
        {
            ViewBag.ListWallet = _userService.GetWalletUser(User.Identity.Name);
            return View();
        }

        [Route("UserPanel/Wallet")]
        [HttpPost]
        public IActionResult Index(ChargeWalletViewModel charge)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.ListWallet = _userService.GetWalletUser(User.Identity.Name);
                return View(charge);
            }
           var walletId=  _userService.ChargeWallet(User.Identity.Name,charge.Amount,"شارژحساب");

            #region Online payment
            var payment = new ZarinpalSandbox.Payment(charge.Amount);
            var res = payment.PaymentRequest("شارژ کیف پول", "https://localhost:44331/OnlinePayment/" + walletId);

            if (res.Result.Status==100)
            {
                return Redirect("https://sandbox.zarinpal.com/pg/StartPay/" + res.Result.Authority);
            }
            #endregion

            return null;
        }
    }
}
