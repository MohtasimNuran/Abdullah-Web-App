using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AbdullahWebApp.Controllers
{
    public class LoadMachineController : Controller
    {
        MachineDBEntities db = new MachineDBEntities();
        LoadMachine loadMachine = new LoadMachine();
        //
        // GET: /LoadMachine/
        //        public ActionResult Index()
        //        {
        //            return View();
        //        }
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.Buyer = new SelectList(db.BuyerInfoes, "Id", "BuyerName");

            ViewBag.FinishType = new SelectList(db.FinishInfoes, "Id", "FinishName");

            ViewBag.RemarksAndPrecautions = new SelectList(db.RemarksInfoes, "Id", "RemarksName");

            ViewBag.OrderCode = new SelectList(db.OrderCodeInfoes, "Id", "OrderCodeName");
            return View();
        }
        [HttpPost]
        public ActionResult Create(LoadMachine loadMachine)
        {
            ViewBag.Buyer = new SelectList(db.BuyerInfoes, "Id", "BuyerName");

            ViewBag.FinishType = new SelectList(db.FinishInfoes, "Id", "FinishName");

            ViewBag.RemarksAndPrecautions = new SelectList(db.RemarksInfoes, "Id", "RemarksName");

            ViewBag.OrderCode = new SelectList(db.OrderCodeInfoes, "Id", "OrderCodeName");
            return View();
        }

        public ActionResult MachineView()
        {
            return View();
        }
    }

}