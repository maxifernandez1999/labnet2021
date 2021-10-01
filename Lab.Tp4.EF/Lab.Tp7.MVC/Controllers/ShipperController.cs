using Lab.Tp7.Entities;
using Lab.Tp7.Logic;
using Lab.Tp7.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services;

namespace Lab.Tp7.MVC.Controllers
{
    public class ShipperController : Controller
    {
        ShipperLogic shipperLogic = new ShipperLogic();
        
        // GET: Shipper
        public ActionResult Index()
        {
            List<Shipper> listShipper = shipperLogic.GetAll();

            List<ShipperView> shipperView = new List<ShipperView>();
            try
            {
                shipperView = listShipper.Select(s => new ShipperView
                {
                    ID = s.ShipperID,
                    CompanyName = s.CompanyName,
                    Phone = s.Phone
                }).ToList();
            }
            catch (Exception)
            {
                throw new Exception();
            }
            
            
            return View(shipperView);
        }

        

        [HttpPost]
        public ActionResult AddOrUpdate(Shipper shipper)
        {
            if (ModelState.IsValid)
            {
                if (shipper.ShipperID == 0)
                {
                    try
                    {
                        shipperLogic.Add(shipper);
                    }
                    catch (Exception)
                    {
                        return RedirectToAction("Index");
                    }
                }
                else
                {
                    try
                    {
                        shipperLogic.Update(shipper);
                    }
                    catch (Exception)
                    {
                        return RedirectToAction("Index");
                    }
                }
            }
            return RedirectToAction("Index");

        }

        
        public JsonResult Delete(Shipper shipper)
        { 
            try
            {
                shipperLogic.Delete(shipper.ShipperID);
            }
            catch (Exception)
            {
                return Json("{'error':404}");
            }
            return Json("{'ok':200}");
        }




    }
}