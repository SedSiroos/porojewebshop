using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Poroject.DataLayer.Entities.Course
{
    public class Course
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public int GroupId { get; set; }
        public int? SubGroup { get; set; }
        [Required]
        public int TeacherId { get; set; }
        [Required]
        public int LevelId { get; set; }
        [Required]
        public int StatusId { get; set; }

        [Display(Name = "عنوان دوره")]
        [Required(ErrorMessage = "لطفا {0} را کامل کنید!!!")]
        [MaxLength(200, ErrorMessage = "{0}نمیتواند بیشتر از {1} کارکتر باشد!!")]
        public string CourseTitle { get; set; }

        [Display(Name = "توضیحات دوره")]
        [Required(ErrorMessage = "لطفا {0} را کامل کنید!!!")]
        public string CourseDescription { get; set; }

        [Display(Name = "قیمت دوره")]
        [Required(ErrorMessage = "لطفا {0} را کامل کنید!!!")]
        public int CoursePrice { get; set; }

        [MaxLength(100)]
        public string CourseImageName { get; set; }

        [MaxLength(100)]
        public string DemoFileName { get; set; }


        [Display(Name = "تاریخ ساخت دوره")]
        [Required(ErrorMessage = "لطفا {0} را کامل کنید!!!")]
        public DateTime CreateDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        [MaxLength(600)]
        public string Tage { get; set; }




        #region Relation

        [ForeignKey("TeacherId")]
        public User.User User { get; set; }

        [ForeignKey("GroupId")]
        public CourseGroup CourseGroup { get; set; }

        [ForeignKey("SubGroup")]
        public CourseGroup Group { get; set; }

        [ForeignKey("LevelId")]
        public CourseLevel CourseLevel { get; set; }

        [ForeignKey("StatusId")]
        public CourseStatus CourseStatus { get; set; }

        public List<CourseEpisode> CourseEpisodes { get; set; }
        #endregion
    }
}
