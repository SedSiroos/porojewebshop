using Poroject.Core.RegisterViewModel;
using Poroject.DataLayer.Entities.User;
using Poroject.DataLayer.Entities.Wallet;
using System;
using System.Collections.Generic;
using System.Text;

namespace Poroject.Core.Services.InterFace
{
    public interface IUserService
    {
        #region IUser
        bool IsExitUsername(string username);
        bool IsExitEmail(string email);
        int Adduser(User user);
        User LoginUser(LoginViewModel login);
        User getUserByEmail(string email);
        User getuserByUserId(int userId);
        User getUserByUserName(string userName);
        int getUserIdbyUserName(string username);
        User getUserByActiveCode(string activeCode);
        void Update(User user);
        bool ActiveAccount(string activeCode);
        #endregion



        #region IUserPanel
        InformationUserViewModel GetUserInformation(string userName);
        SidebarUserPanelViewModel GetSaideBarUserPanelData(string userName);
        EditeProfileViewModel GetDataForEditeProfileUser(string userName);
        void EditProfile(string userName,EditeProfileViewModel profile);
        bool CampairOldPasswordUser(string password, string userName);
        void ChangePasswordUser(string userName, string newPassword);
        #endregion



        #region Wallet
        int BalanceUserWallet(string userName);
        List<WalletViewModel> GetWalletUser(string userName);
        int ChargeWallet(string userName, int amount, string description, bool isPay=false);
        int AddWallet(Wallet wallet);
        Wallet GetWalletIdbywallt(int walletId);
        void UpdateWallet(Wallet wallet);
        #endregion


        #region UserAdmin
        UserForAdminViewModel GetUserAdim(int pageId = 1, string filterEmail = "", string filterUserName="");
        int AddUserForAdmin(CreateUserViewModel user);
        EditeUserViewModel GetUserForShowInEditMode(int userId);
        void EditeUserForAdmin(EditeUserViewModel edit);
        UserForAdminViewModel GetDeleteUserByAdmin(int pageid = 1,string filterUserName = "", string filterEmail = "");
        void DeleteUser(int userId);
        InformationUserViewModel GetUserInformation(int userId);
        #endregion
    }
}