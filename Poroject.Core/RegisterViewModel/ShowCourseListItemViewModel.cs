using System;
using System.Collections.Generic;
using System.Text;

namespace Poroject.Core.RegisterViewModel
{
    public class ShowCourseListItemViewModel
    {
        public int Id { get; set; }
        public String Title { get; set; }
        public string Image { get; set; }
        public int Price { get; set; }
        public TimeSpan TotalTime { get; set; }
    }
}
