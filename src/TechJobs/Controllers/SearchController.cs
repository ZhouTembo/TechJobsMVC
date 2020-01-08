﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TechJobs.Models;

namespace TechJobs.Controllers
{
    public class SearchController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.columns = ListController.columnChoices;
            ViewBag.title = "Search";
            return View();
        }

        public IActionResult Results(string searchType, string searchTerm)
        {
            ViewBag.columns = ListController.columnChoices;
            ViewBag.title = "Search";
            if (searchType.Equals("all"))
            {

                ViewBag.jobs = JobData.FindByValue(searchTerm);
            return View("Index");
            }

            else
            {
                ViewBag.jobs = JobData.FindByColumnAndValue(searchType, searchTerm);
                return View("Index");
            }

        }

        // TODO #1 - Create a Results action method to process 
        // search request and display results

    }
}
