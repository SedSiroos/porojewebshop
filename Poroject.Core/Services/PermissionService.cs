using Poroject.Core.RegisterViewModel;
using Poroject.Core.Services.InterFace;
using Poroject.DataLayer.Context;
using Poroject.DataLayer.Entities.Permissons;
using Poroject.DataLayer.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Poroject.Core.Services
{
    public class PermissionService : IPermissionService
    {
        private PorojectContext _context;
        public PermissionService(PorojectContext context)
        {
            _context = context;
        }
        public List<Role> GetRoles()
        {
            return _context.roles.ToList();
        }
        public void AddRolsToUser(List<int> roleIds, int userId)
        {
            foreach (var item in roleIds)
            {
                _context.userRoles.Add(new UserRole()
                {
                    RoleId=item,
                    UserId=userId,

                });
            }
            _context.SaveChanges();
        }

        public void EditeRoleUser(List<int> rolesId, int userId)
        {   
            //Delete All Roles User
            _context.userRoles.Where(r => r.UserId == userId).ToList().ForEach(r => _context.userRoles.Remove(r));

            //Add new Roles User
            AddRolsToUser(rolesId, userId);
        }

        public Role GetRolesById(int roleId)
        {
            return _context.roles.Find(roleId);
        }
        public void UpdateRole(Role role)
        {
            _context.Update(role);
            _context.SaveChanges();
        }
        public int AddRolesForAdmin(CreateRolesViewModel role)
        {
            Role addRole = new Role();
            addRole.RoleTitle = role.RoleTitle;

            return AddRoles(addRole);
        }

        public int AddRoles(Role role)
        {
            _context.roles.Add(role);
            _context.SaveChanges();
            return role.RoleId;
        }

        public EditeRolesViewModel GetRoleForShowInEditMode(int roleId)
        {
            return _context.roles.Where(r => r.RoleId == roleId).Select(r=> new EditeRolesViewModel()
            {
                RoleId=r.RoleId,
                RoleTitle=r.RoleTitle,
                
            }).Single();
        }

        public void editRoles(EditeRolesViewModel editeRole)
        {
            Role role = GetRolesById(editeRole.RoleId);

            role.RoleTitle = editeRole.RoleTitle;

            _context.roles.Update(role);
            _context.SaveChanges();
        }

        public void DeleteRole(Role role)
        {
            role.IsDelete=true;
            UpdateRole(role);
        }

        public List<Permission> GetAllPermission()
        {
            return _context.Permission.ToList();
        }

        public void AddPermission(int roleId, List<int> permission)
        {
            foreach (var p in permission)
            {
                _context.PermissonRoles.Add(new PermissonRoles()
                {
                    RoleId=roleId,
                    PermissionId=p
                });
            }
            _context.SaveChanges();
        }

        public List<int> SelectedPermissionsRole(int roleId)
        {
            return _context.PermissonRoles.Where(r => r.RoleId == roleId)
                .Select(p => p.PermissionId).ToList();
        }

        public void UpdatePermissionRolle(int roleId, List<int> newPermission)
        {
            _context.PermissonRoles.Where(r=>r.RoleId==roleId).ToList()
                .ForEach (p => _context.PermissonRoles.Remove(p)) ;

            AddPermission(roleId, newPermission);
        }

        public bool CheckPermission(int PermissionId, string userName)
        {
            var userid = _context.users.Single(u => u.UserName == userName).UserId;

            List<int> userRoles = _context.userRoles.
                Where(u => u.UserId == userid)
                .Select(r => r.RoleId).ToList();

            if (!userRoles.Any())
                return false;

            List<int> permissionRoles = _context.PermissonRoles
                .Where(p => p.PermissionId == PermissionId)
                .Select(r => r.RoleId).ToList();

            return permissionRoles.Any(p => userRoles.Contains(p));
        }
    }
}
