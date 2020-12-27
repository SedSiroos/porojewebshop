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
    public class EditCourseModel : PageModel
    {
        private ICourseService _courseService;
        public EditCourseModel(ICourseService courseService)
        {
            _courseService = courseService;
        }
        [BindProperty]
        public Course course { get; set; }
        public void OnGet(int id)
        {
            course = _courseService.GetCourseById(id);

            var groups = _courseService.GetGroupForManageCourse();
            ViewData["Groups"] = new SelectList(groups,"Value","Text", course.GroupId);

            var subGroups = _courseService.GetSubGroupForManageCourse(int.Parse(groups.First().Value));
            ViewData["SubGroups"] = new SelectList(subGroups, "Value", "Text", course.SubGroup??0);

            var teacher = _courseService.GetTeachers();
            ViewData["Teachers"] = new SelectList(teacher, "Value", "Text", course.TeacherId);

            var levels = _courseService.GetLeveles();
            ViewData["Leveles"] = new SelectList(levels, "Value", "Text", course.LevelId);

            var status = _courseService.GetStatues();
            ViewData["Statues"] = new SelectList(status, "Value", "Text", course.StatusId);
        }

        public IActionResult OnPost(IFormFile imgCourseUp, IFormFile demoUp)
        {
            //if (ModelState.IsValid)
            //    return Page();

            _courseService.UpdateCourse(course,imgCourseUp, demoUp);
            return RedirectToPage("Index");
        }
    }
}
