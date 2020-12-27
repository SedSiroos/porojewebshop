using Microsoft.AspNetCore.Mvc;
using Poroject.Core.Services.InterFace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Poroject.Web.ViewComponents
{
    public class CourseGroupComponent:ViewComponent
    {
        private ICourseService _courseService;
        public CourseGroupComponent(ICourseService courseService)
        {
            _courseService = courseService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult((IViewComponentResult)View("CourseGroup",_courseService.GetAllGroup()));
        }
    }
}
