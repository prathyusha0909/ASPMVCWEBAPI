using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWithWebApi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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
        //This action method is for loading the Create Product feature
        //as a part of a AJAX operation.
        public ActionResult CreateProduct()
        {
            //We are returing a partial view,and not a full view,as we do not
            //want the header and footer parts to be there.The header and footer
            //is already visible as apart of home/index request.We just
            //want the create view to be inserted into the index view.
            return PartialView();
        }
    }
}