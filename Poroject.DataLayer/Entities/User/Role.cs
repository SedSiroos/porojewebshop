using Poroject.DataLayer.Entities.Permissons;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Poroject.DataLayer.Entities.User
{
    public class Role
    {
        public Role()
        {

        }

        [Key]
        public int RoleId { get; set; }

        [Display(Name = "عنوان گروه")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید.")]
        [MaxLength(200, ErrorMessage = "{1}نمیتواند بیشتر از {0}باشد.")]
        public string RoleTitle { get; set; }
        public bool IsDelete { get; set; }


        #region Relation
        public virtual List<UserRole> userRole { get; set; }
        public virtual List<PermissonRoles> PermissonRole { get; set; }
        #endregion
    }
}
