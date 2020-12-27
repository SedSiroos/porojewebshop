using Poroject.Core.RegisterViewModel;
using Poroject.DataLayer.Entities.Permissons;
using Poroject.DataLayer.Entities.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace Poroject.Core.Services.InterFace
{
    public interface IPermissionService
    {
        #region Roles

        List<Role> GetRoles();
        void AddRolsToUser(List<int> rolsIds, int userId);
        void EditeRoleUser(List<int> rolesId, int userId);
        int AddRolesForAdmin(CreateRolesViewModel role);
        int AddRoles(Role role);
        EditeRolesViewModel GetRoleForShowInEditMode(int roleId);
        void editRoles(EditeRolesViewModel editeRole);
        Role GetRolesById(int roleId);
        void DeleteRole(Role role);
        void UpdateRole(Role role);

        #endregion

        #region Permissions
        List<Permission> GetAllPermission();
        void AddPermission(int roleId, List<int> permission);
        List<int> SelectedPermissionsRole(int roldeId);
        void UpdatePermissionRolle(int roleId, List<int> newPermission);
        bool CheckPermission(int PermissionId, string userName);
        #endregion
    }
}
