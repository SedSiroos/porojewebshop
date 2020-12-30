using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Poroject.Core.Services.InterFace;
using Poroject.DataLayer.Context;
using Poroject.DataLayer.Entities.Course;
using Poroject.Core.Generator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Poroject.Core.RegisterViewModel;
using Poroject.Core.Convertors;
using Poroject.Core.Security;

namespace Poroject.Core.Services
{
    public class CourseService : ICourseService
    {
        private PorojectContext _context;
        public CourseService(PorojectContext context)
        {
            _context = context;
        }

        public List<CourseGroup> GetAllGroup()
        {
            return _context.courseGroups.ToList();
        }

        public List<SelectListItem> GetGroupForManageCourse()
        {
            return _context.courseGroups.Where(g => g.ParentId == null)
                .Select(g => new SelectListItem()
                {
                    Text = g.GroupTitle,
                    Value = g.GroupId.ToString()
                }).ToList();
        }

        public List<SelectListItem> GetSubGroupForManageCourse(int groupId)
        {
            return _context.courseGroups.Where(g => g.ParentId == groupId)
                .Select(g => new SelectListItem()
                {
                    Text = g.GroupTitle,
                    Value = g.GroupId.ToString()
                }).ToList();
        }

        public List<SelectListItem> GetTeachers()
        {
            return _context.userRoles.Where(r => r.RoleId == 5).Include(u => u.User)
                .Select(u => new SelectListItem()
                {
                    Value = u.UserId.ToString(),
                    Text = u.User.UserName
                }).ToList();
        }

        public List<SelectListItem> GetLeveles()
        {
            return _context.CourseLevels.Select(l => new SelectListItem()
            {
                Text = l.LevelTitle,
                Value = l.LevelId.ToString(),
            }).ToList();
        }

        public List<SelectListItem> GetStatues()
        {
            return _context.CourseStatuses.Select(s => new SelectListItem()
            {
                Text = s.StatusTitle,
                Value = s.StatusId.ToString(),
            }).ToList();
        }

        public int AddCourse(Course course, IFormFile imgCourse, IFormFile courseDemo)
        {
            course.CreateDate = DateTime.Now;
            course.CourseImageName = "images.png";

            //TODO check image

            if (imgCourse != null && imgCourse.IsImage())
            {
                course.CourseImageName = NameGenarator.GeneratorUniqCode() + Path.GetExtension(imgCourse.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/imageCourses/image", course.CourseImageName);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgCourse.CopyTo(stream);
                }
                ImageConvertor imageResize = new ImageConvertor();

                string thumbPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/imageCourses/thumbnil", course.CourseImageName);

                imageResize.Image_resize(imagePath, thumbPath, 100);
            }

            if (courseDemo != null)
            {
                course.DemoFileName = NameGenarator.GeneratorUniqCode() + Path.GetExtension(courseDemo.FileName);
                string demoPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/imageCourses/Demoes", course.DemoFileName);
                using (var stream = new FileStream(demoPath, FileMode.Create))
                {
                    courseDemo.CopyTo(stream);
                }
            }


            _context.Add(course);
            _context.SaveChanges();
            return course.ID;

        }

        public List<ShowCourseForAdminViewModel> ShowCourseForAdmin()
        {
            return _context.courses.Select(c => new ShowCourseForAdminViewModel()
            {
                CourseId = c.ID,
                Title = c.CourseTitle,
                EpisodeCount = c.CourseEpisodes.Count,
                CreateDate = c.CreateDate,
                image = c.CourseImageName
            }).ToList();

        }

        public Course GetCourseById(int courseId)
        {
            return _context.courses.Find(courseId);
        }

        public void UpdateCourse(Course course, IFormFile imgCourse, IFormFile courseDemo)
        {
            course.UpdateDate = DateTime.Now;
            if (imgCourse != null && imgCourse.IsImage())
            {
                if (course.CourseImageName != "images.png")
                {
                    string deleteimagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/imageCourses/image", course.CourseImageName);
                    if (File.Exists(deleteimagePath))
                    {
                        File.Delete(deleteimagePath);
                    }

                    string deletThumbPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/imageCourses/thumbnil", course.CourseImageName);
                    if (File.Exists(deletThumbPath))
                    {
                        File.Delete(deletThumbPath);
                    }
                }
                course.CourseImageName = NameGenarator.GeneratorUniqCode() + Path.GetExtension(imgCourse.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/imageCourses/image", course.CourseImageName);
                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgCourse.CopyTo(stream);
                }

                ImageConvertor imgResize = new ImageConvertor();
                string thumbPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/imageCourses/thumbnil", course.CourseImageName);
                imgResize.Image_resize(imagePath, thumbPath, 100);
            }

            if (courseDemo != null)
            {
                if (course.DemoFileName != null)
                {
                    string deletDemoPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/imageCourses/Demoes", course.DemoFileName);
                    if (File.Exists(deletDemoPath))
                    {
                        File.Delete(deletDemoPath);
                    }
                }
                course.DemoFileName = NameGenarator.GeneratorUniqCode() + Path.GetExtension(course.DemoFileName);
                string demoPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/imageCourses/Demoes", course.DemoFileName);
                using (var stream = new FileStream(demoPath, FileMode.Create))
                {
                    courseDemo.CopyTo(stream);
                }
            }
            _context.courses.Update(course);
            _context.SaveChanges();
        }

        public int AddEpisode(CourseEpisode episode, IFormFile EpisodeFile)
        {
            episode.CreateDate = DateTime.Now;

            episode.EpisodeFileName = EpisodeFile.FileName;
            string FilePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/FileEpisode", episode.EpisodeFileName);
            using (var stream = new FileStream(FilePath, FileMode.Create))
            {
                EpisodeFile.CopyTo(stream);
            }

            _context.CourseEpisodes.Add(episode);
            _context.SaveChanges();
            return episode.EpisodeId;
        }

        public List<CourseEpisode> GetShowListEpisode(int courseId)
        {
            return _context.CourseEpisodes.Where(e => e.ID == courseId).ToList();
        }

        public bool IsCheckExistFileEpisode(string fileName)
        {
            string pathFileEpisode = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/FileEpisode", fileName);
            return File.Exists(pathFileEpisode);
        }

        public CourseEpisode GetEpisodById(int episodeId)
        {
            return _context.CourseEpisodes.Find(episodeId);
        }

        public void EditeEpisode(CourseEpisode episode, IFormFile fileEpisdoe)
        {
            episode.CreateDate = DateTime.Now;

            if (fileEpisdoe != null)
            {
                string deletepath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/FileEpisode", episode.EpisodeFileName);
                File.Delete(deletepath);

                episode.EpisodeFileName = fileEpisdoe.FileName;
                string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/FileEpisode", episode.EpisodeFileName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    fileEpisdoe.CopyTo(stream);
                }
            }
            _context.CourseEpisodes.Update(episode);
            _context.SaveChanges();
        }

        

        public Tuple<List<ShowCourseListItemViewModel>,int> GetCourse(int pageId = 1, string filter = "", string getType = "all",
            string getOrderByType = "date",int startPrice=0,int endPrice=0 , List<int> selectedGroups = null, int take = 0)
        {
            IQueryable<Course> result = _context.courses;

            if (take == 0)
                take = 8;


            if (!string.IsNullOrEmpty(filter))
            {
                result = result.Where(c => c.CourseTitle.Contains(filter)||c.Tage.Contains(filter));
            }

            switch (getType)
            {
                case "all":
                    break;

                case "buy":
                    {
                        result = result.Where(c => c.CoursePrice != 0);
                        break;
                    }
                case "free":
                    {
                        result = result.Where(c => c.CoursePrice == 0);
                        break;
                    }
            }

            switch (getOrderByType)
            {
                case "date":
                    {
                        result = result.OrderByDescending(c => c.CreateDate);
                        break;
                    }
                case "updatedate":
                    {
                        result = result.OrderByDescending(c => c.UpdateDate);
                        break;
                    }
                case "price":
                    {
                        result = result.OrderByDescending(c => c.CoursePrice);
                        break;
                    }
            }

            if (startPrice>0)
            {
                result = result.Where(c => c.CoursePrice > startPrice);
            }
            if(endPrice>0)
            {
                result = result.Where(c => c.CoursePrice < startPrice);
            }

            if (selectedGroups!=null && selectedGroups.Any())
            {
                foreach (var groupId in selectedGroups)
                {
                    result = result.Where(g => g.GroupId == groupId || g.SubGroup == groupId);
                }
            }
           
          
            int skip=(pageId-1)*take;

            int pageCount = result.Include(c => c.CourseEpisodes).Select(c => new ShowCourseListItemViewModel()
            {
                Id = c.ID,
                Title = c.CourseTitle,
                Price = c.CoursePrice,
                Image = c.CourseImageName,
                //TotalTime = new TimeSpan(c.CourseEpisodes.Sum(e => e.EpisodeTime.Ticks))
            }).Count()/take;

            var query= result.Include(c=>c.CourseEpisodes).Select(c => new ShowCourseListItemViewModel()
            {
                Id = c.ID,
                Title = c.CourseTitle,
                Price = c.CoursePrice,
                Image = c.CourseImageName,
                //TotalTime = new TimeSpan(c.CourseEpisodes.Sum(e => e.EpisodeTime.Ticks))
            }).Skip(skip).Take(take).ToList();

            return Tuple.Create(query, pageCount);
        }

        public Course GetCourseForShow(int courseId)
        {
            return _context.courses.Include(c => c.CourseEpisodes)
                .Include(c => c.CourseStatus).Include(c => c.CourseLevel)
                .Include(c => c.User)
                .FirstOrDefault(c => c.ID == courseId);
        }
    }
}
