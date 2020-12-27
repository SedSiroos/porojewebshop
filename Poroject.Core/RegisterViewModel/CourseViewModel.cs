using System;
using System.Collections.Generic;
using System.Text;

namespace Poroject.Core.RegisterViewModel
{
    #region  ShowCourseForAdminViewModel
    public class ShowCourseForAdminViewModel
    {
        public int CourseId { get; set; }
        public string Title { get; set; }
        public string image { get; set; }
        public int EpisodeCount { get; set; }
        public DateTime CreateDate { get; set; }
    }
    #endregion
}
