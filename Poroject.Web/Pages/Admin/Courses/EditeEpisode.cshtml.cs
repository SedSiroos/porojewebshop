using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Poroject.Core.Services.InterFace;
using Poroject.DataLayer.Entities.Course;

namespace Poroject.Web.Pages.Admin.Courses
{
    public class EditeEpisodeModel : PageModel
    {
        private ICourseService _courseService;
        public EditeEpisodeModel(ICourseService courseService)
        {
            _courseService = courseService;
        }
        [BindProperty]
        public CourseEpisode courseEpisode { get; set; }

        public void OnGet(int id)
        {
            @ViewData["IDcourse"] = id;
            courseEpisode = _courseService.GetEpisodById(id);
        }
        public IActionResult OnPost(IFormFile fileEpisode)
        {
            if (!ModelState.IsValid)
                return Page();

            if (fileEpisode!=null)
            {
                if (_courseService.IsCheckExistFileEpisode(fileEpisode.FileName))
                {
                    ViewData["IsExist"] = true;
                    return Page();
                }
            }

             _courseService.EditeEpisode(courseEpisode,fileEpisode);
            return Redirect("/Admin/Courses/IndexEpisode/" + courseEpisode.ID);
        }
    }
}
