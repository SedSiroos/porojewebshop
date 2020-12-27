using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Poroject.DataLayer.Entities.Permissons
{
    public class Permission
    {
        public Permission()
        {

        }
        [Key]
        public int PermissionId { get; set; }

        [Display(Name = "عنوان نقش")]
        [Required(ErrorMessage = "لطفا {0} را کامل کنید!!!")]
         [MaxLength(200, ErrorMessage = "{0}نمیتواند بیشتر از {1} کارکتر باشد!!")]
        public string PermissionTitle { get; set; }

        public int? ParentId { get; set; }


        #region Relation
        [ForeignKey("ParentId")]
        public virtual List<Permission> permission { get; set; }
        public virtual List<PermissonRoles> PermissonRole { get; set; }
        #endregion
    }
}
