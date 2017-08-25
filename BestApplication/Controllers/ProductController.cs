using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace BestApplication.Controllers
{
    public class ProductController : Controller
    {
        // GET: san-pham
        [HttpGet]
        [Route("san-pham")]
        public IActionResult Index()
        {
            return View();
        }

        // GET: san-pham/id
        [HttpGet]
        [Route("san-pham/{id?}")]
        public IActionResult Details(int id)
        {
            ViewData["TitleContent"] = "Chi tiết sản phẩm "+ id +"";
            return View();
        }

        // GET: them-moi-san-pham
        [HttpGet]
        [Route("them-moi-san-pham")]
        [Authorize(Roles = "Admin")]
        public IActionResult AddNew()
        {
            ViewData["TitleContent"] = "Thêm mới sản phẩm";
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Edit/5
        public IActionResult Edit(int id)
        {
            return View();
        }

        // POST: Product/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

   
        // POST: Product/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}