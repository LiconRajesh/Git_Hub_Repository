using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Git_Hub_Repository.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            string str = "rajesh";
            StringBuilder sb = new StringBuilder();
            sb.Append("Welcome rajesh to this page");
            return Content("Hii Rajesh");
        }



    }
}