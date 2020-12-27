using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Poroject.DataLayer.Entities.Course
{
    public class CourseStatus
    {
        [Key]
        public int StatusId { get; set; }

        [Required]
        [MaxLength(400, ErrorMessage = "{0}نمیتواند بیشتر از {1} کارکتر باشد!!")]
        public string StatusTitle { get; set; }


        #region RElation
        public List<Course> Course { get; set; }
        #endregion
    }
}
