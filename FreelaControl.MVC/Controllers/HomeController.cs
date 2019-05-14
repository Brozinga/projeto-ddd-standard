using FreelaControl.Domain.Interfaces;
using FreelaControl.Services.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FreelaControl.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUsuarioService _service;

        public HomeController(IUsuarioService service)
        {
            _service = service;
        }
        public ActionResult Index()
        {

            _service.GetAll();
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}