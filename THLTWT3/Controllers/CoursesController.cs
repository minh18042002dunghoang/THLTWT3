﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using THLTWT3.Models;
using THLTWT3.ViewModels;

namespace THLTWT3.Controllers
{
    
    public class CoursesController : Controller
    {
        private readonly ApplicationDbContext _dbContext = new ApplicationDbContext();


        // GET: Courses
        public ActionResult Create()
        {
            var viewModel = new CourseViewModel()
            {
                Categories = _dbContext.Categories.ToList()
            };
            return View(viewModel);
        }
    }
}