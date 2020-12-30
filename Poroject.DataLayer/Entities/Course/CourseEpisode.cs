using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Poroject.DataLayer.Entities.Course
{
    public class CourseEpisode
    {
        [Key]
        public int EpisodeId { get; set; }
        public int ID { get; set; }

        [Display(Name = "عنوان بخش")]
        [Required(ErrorMessage = "لطفا {0} را کامل کنید!!!")]
        [MaxLength(400, ErrorMessage = "{0}نمیتواند بیشتر از {1} کارکتر باشد!!")]
        public string EpisodeTitle { get; set; }

        [Display(Name = "زمان")]
        [Required(ErrorMessage = "لطفا {0} را کامل کنید!!!")]
        public TimeSpan EpisodeTime { get; set; }

        [Display(Name = "فایل")]
        public string EpisodeFileName { get; set; }

        [Display(Name = "رایگان")]
        public bool IsFree { get; set; }

        [Display(Name = "تاریخ ساخت دوره")]
        [Required(ErrorMessage = "لطفا {0} را کامل کنید!!!")]
        public DateTime CreateDate { get; set; }
        public bool IsDelete { get; set; }


        #region Relation
        [ForeignKey("ID")]
        public Course Course { get; set; }
        #endregion
    }
}
