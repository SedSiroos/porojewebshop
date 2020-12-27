using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Poroject.DataLayer.Entities.Course
{
    public class CourseGroup
    {
        [Key]
        public int GroupId { get; set; } 

        [Display(Name = "عنوان گروه")]
        [Required(ErrorMessage = "لطفا {0} را کامل کنید!!!")]
        [MaxLength(200, ErrorMessage = "{0}نمیتواند بیشتر از {1} کارکتر باشد!!")]
        public string GroupTitle { get; set; }

        [Display(Name = "حذف شده؟")]
        public bool IsDelete { get; set; }

        [Display(Name = "گروه اصلی")]
        public int? ParentId { get; set; }




        #region Relation
        [ForeignKey("ParentId")]
        public List<CourseGroup> courseGroups { get; set; }

        [InverseProperty("CourseGroup")]
        public List<Course> Courses { get; set; }

        [InverseProperty("Group")]
        public List<Course> CourseSub { get; set; }
        #endregion
    }
}
