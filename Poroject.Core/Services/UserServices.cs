using Microsoft.EntityFrameworkCore;
using Poroject.Core.Convertors;
using Poroject.Core.Generator;
using Poroject.Core.RegisterViewModel;
using Poroject.Core.Security;
using Poroject.Core.Services.InterFace;
using Poroject.DataLayer.Context;
using Poroject.DataLayer.Entities.User;
using Poroject.DataLayer.Entities.Wallet;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Poroject.Core.Services
{
    public class UserServices:IUserService
    {
        private PorojectContext _context;
        public UserServices(PorojectContext context)
        {
            _context = context;
        }

        public bool IsExitUsername(string username)
        {
            return _context.users.Any(u => u.UserName == username);
        }
        public bool IsExitEmail(string email)
        {
            return _context.users.Any(u => u.Email == email);
        }

        public int Adduser(User user)
        {
            _context.users.Add(user);
            _context.SaveChanges();
            return user.UserId;
        }

        public User LoginUser(LoginViewModel login)
        {
            string hashpassword = PasswordHelper.EncodePasswordMd5(login.Password);
            string email = FixedText.FixedEmail(login.Email);
            return _context.users.SingleOrDefault(u => u.Email == email && u.Password == hashpassword);
        }

        public bool ActiveAccount(string activeCode)
        {
            var user= _context.users.SingleOrDefault(u => u.ActiveCode == activeCode);

            if (user == null || user.Isactive)
                return false;

            user.Isactive = true;
            user.ActiveCode = NameGenarator.GeneratorUniqCode();
            _context.SaveChanges();
            return true;
        }

        public User getUserByEmail(string email)
        {
            return _context.users.SingleOrDefault(u => u.Email == email);
        }
        public User getuserByUserId(int userId)
        {
            return _context.users.Find(userId);
        }
        public User getUserByUserName(string userName)
        {
            return _context.users.SingleOrDefault(u => u.UserName == userName);
        }
        public int getUserIdbyUserName(string username)
        {
            return _context.users.Single(u => u.UserName == username).UserId;
        }
        public User getUserByActiveCode(string activeCode)
        {
           return _context.users.SingleOrDefault(u => u.ActiveCode == activeCode);
        }

        public void Update(User user)
        {
             _context.Update(user);
            _context.SaveChanges();
        }

        public InformationUserViewModel GetUserInformation(string userName)
        {
            var user = getUserByUserName(userName);
            InformationUserViewModel information = new InformationUserViewModel();

            information.UserName = user.UserName;
            information.Email = user.Email;
            information.Registerdate = user.RegisterDate;
            information.Wallet = BalanceUserWallet(userName);

            return information;
        }

        public SidebarUserPanelViewModel GetSaideBarUserPanelData(string userName)
        {
            return _context.users.Where(u => u.UserName == userName).Select(u => new SidebarUserPanelViewModel
            {
                UserName=u.UserName,
                Registerdate=u.RegisterDate,
                ImageName=u.UserAvatar
            }).Single();
        }

        public EditeProfileViewModel GetDataForEditeProfileUser(string userName)
        {
            return _context.users.Where(u => u.UserName == userName).Select(u => new EditeProfileViewModel
            {
                UserName=u.UserName,
                Email=u.Email,
                AvatarName=u.UserAvatar
            }).Single();
        }

        public void EditProfile(string userName,EditeProfileViewModel profile)
        {
            if (profile.UserAvatar !=null)
            {
                string imagePath = "";
                if (profile.AvatarName != "images.jpg")
                {
                    imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/UserAvatar", profile.AvatarName);
                    if (File.Exists(imagePath))
                    {
                        File.Delete(imagePath);
                    }

                    profile.AvatarName = NameGenarator.GeneratorUniqCode() + Path.GetExtension(profile.UserAvatar.FileName);
                    imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/UserAvatar", profile.AvatarName);

                    using (var stream=new FileStream(imagePath,FileMode.Create))
                    {
                        profile.UserAvatar.CopyTo(stream);
                    }
                }
            }

            var user = getUserByUserName(userName);
            user.UserName = profile.UserName;
            user.Email = profile.Email;
            user.UserAvatar = profile.AvatarName;

            Update(user);
        }

        public bool CampairOldPasswordUser(string password, string userName)
        {
            var HassOldPass = PasswordHelper.EncodePasswordMd5(password);

            return _context.users.Any(u => u.Password == password && u.UserName == userName);
            
        }
        public void ChangePasswordUser(string userName, string newPassword)
        {
            var user = getUserByUserName(userName);
            user.Password = PasswordHelper.EncodePasswordMd5(newPassword);
            Update(user);
        }

        public int BalanceUserWallet(string userName)
        {
            int userID = getUserIdbyUserName(userName);

            var deposit = _context.wallets.Where(w => w.UserId == userID && w.TypeId == 1 && w.IsPay)
                .Select(w => w.Amount).ToList();
            var withdraw = _context.wallets.Where(w => w.UserId == userID && w.TypeId == 2)
                .Select(w => w.Amount).ToList();

            return (deposit.Sum() - withdraw.Sum());
        }

        public List<WalletViewModel> GetWalletUser(string userName)
        {
            int userId = getUserIdbyUserName(userName);

            return _context.wallets.Where(w => w.UserId == userId && w.IsPay)
                .Select(w => new WalletViewModel
                {
                    Amount=w.Amount,
                    Type=w.TypeId,
                    CreateDate=w.CreateDate,
                    Description=w.Description
                }).ToList();
        }

        public int ChargeWallet(string userName, int amount, string description, bool isPay = false)
        {
            Wallet wallet = new Wallet()
            {
                Amount = amount,
                CreateDate = DateTime.Now,
                Description = description,
                IsPay = isPay,
                TypeId=1,
                UserId = getUserIdbyUserName(userName)
            };
            return AddWallet(wallet);
        }

        public int AddWallet(Wallet wallet)
        {
            _context.wallets.Add(wallet);
            _context.SaveChanges();
            return wallet.WalletId;
        }

        public Wallet GetWalletIdbywallt(int walletId)
        {
            return _context.wallets.Find(walletId);
        }

        public void UpdateWallet(Wallet wallet)
        {
            _context.wallets.Update(wallet);
            _context.SaveChanges();
        }

        public UserForAdminViewModel GetUserAdim(int pageId = 1, string filterEmail = "", string filterUserName = "")
        {
            IQueryable<User> result = _context.users;

            if (!string.IsNullOrEmpty(filterEmail))
            {
                //result= result.Where(u => u.Email.Contains(filterEmail));
                result = result.Where(u => EF.Functions.Like(u.Email,filterEmail));
            }
            if (!string.IsNullOrEmpty(filterUserName))
            {
                //result = result.Where(u => u.UserName.Contains(filterUserName));
                result = result.Where(u => EF.Functions.Like(u.UserName,filterUserName));
            }


            int take = 20;
            int skip = (pageId - 1) * take;

            UserForAdminViewModel list = new UserForAdminViewModel();
            list.CurrentPage = pageId;
            list.PageCount = result.Count() / take;

            list.UsersAdmin = result.OrderBy(u => u.RegisterDate).Skip(skip).Take(take).ToList();
            return list;
        }

        public int AddUserForAdmin(CreateUserViewModel user)
        {
            User adduser = new User();
            adduser.UserName = user.UserName;
            adduser.Email = user.Email;
            adduser.Password = PasswordHelper.EncodePasswordMd5(user.Password);
            adduser.ActiveCode = NameGenarator.GeneratorUniqCode();
            adduser.Isactive = true;
            adduser.RegisterDate = DateTime.Now;
            //if (user.AvatarUser!=null)
            //{
            //string imagePath = "";
            //adduser.UserAvatar = NameGenarator.GeneratorUniqCode() + Path.GetExtension(user.AvatarUser.FileName);
            //imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/UserAvatar",adduser.UserAvatar);

            //using (var stream = new FileStream(imagePath, FileMode.Create))
            //{
            //    user.AvatarUser.CopyTo(stream);
            //}
            //};

            return Adduser(adduser);
        }

        public EditeUserViewModel GetUserForShowInEditMode(int userId)
        {
           return _context.users.Where(u => u.UserId == userId).Select(u => new EditeUserViewModel()
            {
               UserId=u.UserId,
                UserName = u.UserName,
                Email = u.Email,
                AvatarName = u.UserAvatar,
                userRoles=u.userRole.Select(r=>r.RoleId).ToList(),
               
            }).Single();
        }

        public void EditeUserForAdmin(EditeUserViewModel editUser)
        {
            User user = getuserByUserId(editUser.UserId);

            user.Email = editUser.Email;
            if (!string.IsNullOrEmpty(editUser.Password))
            {
                user.Password = PasswordHelper.EncodePasswordMd5(editUser.Password);
            }

            //if (editUser.AvatarUser!=null)
            //{
            //    if (editUser.AvatarName != "images.jpg")
            //    {
            //        string deletePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/UserAvatar", editUser.AvatarName);
            //        if (File.Exists(deletePath))
            //        {
            //            File.Delete(deletePath);
            //        }
            //    }

            //    user.UserAvatar = NameGenarator.GeneratorUniqCode() + Path.GetExtension(editUser.AvatarUser.FileName);
            //    string imagepath = Path.Combine(Directory.GetCurrentDirectory() + "wwwroot/UserAvatar", user.UserAvatar);
            //    using (var stream=new FileStream(imagepath,FileMode.Create))
            //    {
            //        editUser.AvatarUser.CopyTo(stream);
            //    }
            //}

            user.Isactive = editUser.IsActive;
            _context.users.Update(user);
            _context.SaveChanges();
        }

        public UserForAdminViewModel GetDeleteUserByAdmin(int pageId = 1, string filterUserName = "", string filterEmail = "")
        {
           IQueryable<User> users = _context.users.IgnoreQueryFilters().Where(u=>u.IsDelete);

            if (!string.IsNullOrEmpty(filterUserName))
            {
                users = users.Where(u => u.UserName.Contains(filterUserName));
            }
            if (!string.IsNullOrEmpty(filterEmail))
            {
                users = users.Where(u => u.Email.Contains(filterEmail));
            }

            int take = 20;
            int skip = (pageId - 1) * take;
            UserForAdminViewModel list = new UserForAdminViewModel();
            list.CurrentPage = pageId;
            list.PageCount = users.Count() / take;
            list.UsersAdmin = users.OrderBy(u => u.RegisterDate).Skip(skip).Take(take).ToList();
            return list;
        }
        public InformationUserViewModel GetUserInformation(int userId)
        {
            User user = getuserByUserId(userId);
            InformationUserViewModel information = new InformationUserViewModel();
            information.UserName = user.UserName;
            information.Email = user.Email;
            information.Registerdate= user.RegisterDate;
            information.Wallet=BalanceUserWallet(user.UserName);

            return information;
        }

        public void DeleteUser(int userId)
        {
            User user = getuserByUserId(userId);
            user.IsDelete = true;
            Update(user);
        }
    }
}
    