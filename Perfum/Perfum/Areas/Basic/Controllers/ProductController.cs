using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Perfum.Areas.Basic.Controllers
{
    public class ProductController : Controller
    {
        // GET: Basic/Product
        public ActionResult Index()
        {
            return View();
        }
    }
}