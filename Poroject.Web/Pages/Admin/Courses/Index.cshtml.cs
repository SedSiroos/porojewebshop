using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Poroject.Core.RegisterViewModel;
using Poroject.Core.Services.InterFace;

namespace Poroject.Web.Pages.Admin.Courses
{
    public class IndexModel : PageModel
    {
        private ICourseService _courseService;
        public IndexModel(ICourseService courseService)
        {
            _courseService = courseService;
        }

        public List<ShowCourseForAdminViewModel> ListCourse { get; set; }
        public void OnGet()
        {
            ListCourse = _courseService.ShowCourseForAdmin();
        }
    }
}
