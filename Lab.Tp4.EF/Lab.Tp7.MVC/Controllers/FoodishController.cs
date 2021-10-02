using Lab.Tp4.EF.Entities.DTO;
using Lab.Tp4.EF.Logic;
using Lab.Tp7.MVC.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Lab.Tp7.MVC.Controllers
{
    public class FoodishController : Controller
    {
        public async Task<ActionResult> Index()
        {
            FoodishViewModel foodishViewModel = new FoodishViewModel();
            FoodishLogic foodish = new FoodishLogic();
            try
            {
                Foodish food = await foodish.GetAll();
                foodishViewModel = new FoodishViewModel
                {
                    Image = food.Image
                };
                return View(foodishViewModel);
            }
            catch (Exception)
            {
                return RedirectToAction("Error");
            }
        }

        public void Error()
        {
            ViewBag.Error = "Ha ocurrido un error";
        }
    }
}