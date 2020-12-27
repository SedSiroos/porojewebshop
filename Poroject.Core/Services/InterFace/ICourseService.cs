using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Poroject.Core.RegisterViewModel;
using Poroject.DataLayer.Entities.Course;
using System;
using System.Collections.Generic;
using System.Text;

namespace Poroject.Core.Services.InterFace
{
   public interface ICourseService
    {
        #region CourseGroup
        List<CourseGroup> GetAllGroup();
        List<SelectListItem> GetGroupForManageCourse();// گرفتن کل گروها
        List<SelectListItem> GetSubGroupForManageCourse(int groupId);//گرفتن زیر گروه ها توسط ادمین
        List<SelectListItem> GetTeachers();
        List<SelectListItem> GetLeveles();
        List<SelectListItem> GetStatues();
        #endregion


        #region Course
        int AddCourse(Course course, IFormFile imgCourse, IFormFile courseDemo);
        List<ShowCourseForAdminViewModel> ShowCourseForAdmin();
        Course GetCourseById(int courseId);
        void UpdateCourse(Course course, IFormFile imgCourse, IFormFile courseDemo);
        Tuple<List<ShowCourseListItemViewModel>,int> GetCourse(int pageId = 1, string filter = "", string getType = "all",
               string getOrderByType = "date", int startPrice = 0, int endPrice = 0, List<int> selectedGroups = null, int take = 0);//برای نمایش دادن دوره ها در صفحه اصلی
        #endregion

        #region Episode
        int AddEpisode(CourseEpisode episode, IFormFile EpisodeFile);
        List<CourseEpisode> GetShowListEpisode(int courseId);
        bool IsCheckExistFileEpisode(string fileName);
        CourseEpisode GetEpisodById(int episodeId);
        void EditeEpisode(CourseEpisode episode, IFormFile fileEpisdoe);
        void DeleteEpisoed(int episodeId);
        #endregion

    }
}