using Poroject.DataLayer.Entities.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Poroject.DataLayer.Entities.Permissons
{
   public class PermissonRoles
    {
        public PermissonRoles()
        {

        }
        [Key]
        public int PR_ID { get; set; }

        public int RoleId { get; set; }
        public int PermissionId { get; set; }
                   

        #region RElations
        public virtual Permission Permission { get; set; }
        public virtual Role Role { get; set; }
        #endregion
    }
}
