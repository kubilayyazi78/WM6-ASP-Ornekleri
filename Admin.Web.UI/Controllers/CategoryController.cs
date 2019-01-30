﻿using Admin.BLL.Repository;
using Admin.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Admin.Web.UI.Controllers
{
    public class CategoryController : BaseController
    {
        
        // GET: Category
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Add()
        {
            ViewBag.CategoryList = GetCategorySelectList();
            return View();
        }

        [HttpPost]
        public ActionResult Add(Category model)
        {

            try
            {
                model.TaxRate /= 100;
                if (model.SupCategoryId == 0) model.SupCategoryId = null;
                new CategoryRepo().Insert(model);
                return RedirectToAction("Add");
            }
            catch (Exception ex)
            {
                //todo: hata sayfası yaz
                return RedirectToAction("Add");
            }



            return View();
        }
    }
}