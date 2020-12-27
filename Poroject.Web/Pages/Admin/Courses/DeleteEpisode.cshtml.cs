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
    public class DeleteEpisodeModel : PageModel
    {
        private ICourseService _courseService;
        public DeleteEpisodeModel(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [BindProperty]
        public CourseEpisode CourseEpisode { get; set; }
        public void OnGet(int id)
        {
            CourseEpisode = _courseService.GetEpisodById(id);
        }
        public IActionResult OnPost(int id)
        {
            _courseService.DeleteEpisoed(id);
            return RedirectToPage("IndexEpisode");
        }
    }
}
