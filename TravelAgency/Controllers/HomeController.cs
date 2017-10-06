using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using TravelAgency.BusinessLayer;
using TravelAgency.BusinessLayer.Base;
using TravelAgency.BusinessLayer.Country;
using TravelAgency.BusinessLayer.ViewModels;
using TravelAgency.DataAccess.Models;

namespace TravelAgency.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICountryService _countryService;
        

        public HomeController()
        {
            
        }
        public HomeController(ICountryService countryService)
        {
            _countryService = countryService;
        }

        public ActionResult Index()
        {
            _countryService.GetAll();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}