using big_school_ntk.Models;
using big_school_ntk.ViewModels;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace big_school_ntk.Controllers
{
    public class CoursesController : Controller
    {
        // GET: Course
        private readonly ApplicationDbContext _dbContext;
        public CoursesController()
        {
            _dbContext = new ApplicationDbContext();
        }
        [Authorize]
        public ActionResult Create()
        {
            var viewModel = new CourseViewModels
            {
                Categories = _dbContext.Categories.ToList()
            };
            return View(viewModel);
        }
       
    }
}
