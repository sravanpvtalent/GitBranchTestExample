using EmptyRepos.BussinessAccessLayer;
using EmptyRepos.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmptyRepos.Controllers
{
    public class EmptyController : Controller
    {
        bal objbal = new bal(new repos());
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult PIndex()
        {
            return View();
        }
        public ActionResult KIndex()
        {
            return View();
        }
         public ActionResult OIndex()
        {
            return View();
        }

        public ActionResult Show()
        {
            return View();
        }
        public ActionResult opIndex()
        {
            return View();
        }

    }
}
