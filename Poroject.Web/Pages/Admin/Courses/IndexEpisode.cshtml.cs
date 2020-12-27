using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Poroject.Core.Services.InterFace;
using Poroject.DataLayer.Entities.Course;

namespace Poroject.Web.Pages.Admin.Courses
{
    public class IndexEpisodeModel : PageModel
    {
        private ICourseService _courseService;
        public IndexEpisodeModel(ICourseService courseService)
        {
            _courseService = courseService;
        }

        public List<CourseEpisode> courseEpisode { get; set; }

        public void OnGet(int id)
        {
            ViewData["IDcourse"] = id;
            courseEpisode = _courseService.GetShowListEpisode(id);
        }
    }
}
