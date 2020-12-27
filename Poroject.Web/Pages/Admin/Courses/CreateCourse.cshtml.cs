using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Poroject.Core.Services.InterFace;
using Poroject.DataLayer.Entities.Course;

namespace Poroject.Web.Pages.Admin.Courses
{
    public class CreateCourseModel : PageModel
    {
        private ICourseService _courseService;
        public CreateCourseModel(ICourseService couresService)
        {
            _courseService = couresService;
        }

        [BindProperty]
        public Course course { get; set; }
        public void OnGet()
        {
            var groups = _courseService.GetGroupForManageCourse();
            ViewData["Groups"] = new SelectList(groups, "Value", "Text");

            var subGroup = _courseService.GetSubGroupForManageCourse(int.Parse(groups.First().Value));
            ViewData["SubGroup"] = new SelectList(subGroup, "Value", "Text");

            var teacher = _courseService.GetTeachers();
            ViewData["Teachers"] = new SelectList(teacher, "Value", "Text");

            var levels = _courseService.GetLeveles();
            ViewData["Leveles"] = new SelectList(levels, "Value", "Text"); 

            var status = _courseService.GetStatues();
            ViewData["Statues"] = new SelectList(status, "Value", "Text");
        }


        public IActionResult OnPost(IFormFile imgCourseUp,IFormFile demoUp)
        {
            if(!ModelState.IsValid)
            return Page();

            _courseService.AddCourse(course, imgCourseUp, demoUp);
            return RedirectToPage("Index");
        }
    }
}
