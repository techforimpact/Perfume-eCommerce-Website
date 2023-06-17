using BLL;
using BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Perfum.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {

        ProductBL objBL;

        AdminBL objAdmin;

        public HomeController()
        {
            objBL = new ProductBL();
            objAdmin = new AdminBL();
        }
        // GET: Admin/Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ShowProducts() {
            var products = objBL.GetAll();
            return View(products);
        }

        [AcceptVerbs(HttpVerbs.Get | HttpVerbs.Post)]
        public ActionResult Create(tbl_Products product)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    objBL.Insert(product);
                    TempData["SuccessMsg"] = "Product was added successfully.";
                    return RedirectToAction("Create");
                }
                else
                {
                    return View();
                }
            }
            catch 
            {
                TempData["ErrorMsg"] = "Record addition Failed!";
                return RedirectToAction("Create");
            }
        }

        public ActionResult Update()
        {
            return View();
        }

        public ActionResult Delete()
        {

            return View();
        }

        public ActionResult Manage()
        {
            var admins = objAdmin.GetAll();
            return View(admins);
        }

        public ActionResult CreateAdmin(tbl_Admins admin)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    objAdmin.Insert(admin);
                    TempData["SuccessMsg"] = "Product was added successfully.";
                    return RedirectToAction("CreateAdmin");
                }
                else
                {
                    return View();
                }
            }
            catch
            {
                TempData["ErrorMsg"] = "Record addition Failed!";
                return RedirectToAction("CreateAdmin");
            }
        }


    }
}