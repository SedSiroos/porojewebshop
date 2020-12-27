using Microsoft.AspNetCore.Mvc;
using Poroject.Core.Services.InterFace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Poroject.Web.Controllers
{
    public class CourseController : Controller
    {
        private ICourseService _courseService;
        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        } 
        
        public IActionResult Index(int pageId = 1, string filter = "", string getType = "all",
               string getOrderByType = "date", int startPrice = 0, int endPrice = 0, List<int> selectedGroups = null)
        {
            ViewBag.SelectedGroups = selectedGroups;
            ViewBag.pageId = pageId;
            ViewBag.Groups = _courseService.GetAllGroup();
            return View(_courseService.GetCourse(pageId, filter, getType, getOrderByType, startPrice, endPrice, selectedGroups, 1));
        }
    }
}
