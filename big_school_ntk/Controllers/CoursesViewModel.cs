using big_school_ntk.Models;
using System.Linq;

namespace big_school_ntk.Controllers
{
    internal class CoursesViewModel
    {
        public IQueryable<Course> upcommingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}