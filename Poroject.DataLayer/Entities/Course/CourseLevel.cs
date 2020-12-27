using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Poroject.DataLayer.Entities.Course
{
    public class CourseLevel
    {
        [Key]
        public int LevelId { get; set; }

        [Display(Name = "سطح دوره")]
        [Required(ErrorMessage = "لطفا {0} را کامل کنید!!!")]
        [MaxLength(400, ErrorMessage = "{0}نمیتواند بیشتر از {1} کارکتر باشد!!")]
        public string LevelTitle { get; set; }



        #region Relation
        public List<Course> Course { get; set; }
        #endregion
    }
}
