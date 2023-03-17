using Microsoft.AspNetCore.Mvc;
using BlackCoderCoreMVCChartsALLDEMO.Models;
using System;

namespace BlackCoderCoreMVCChartsALLDEMO.Controllers
{
    public class ChartController : Controller
    {
        Random rdn = new Random();

        public IActionResult UseDataTable()
        {
            return View();
        }

        public IActionResult UseDataArray()
        {
            return View();
        }

        public IActionResult UseJsonData()
        {
            return View();
        }

        public IActionResult UseDataFromServer()
        {
            return View();
        }

        public IActionResult RealTimeChart()
        {
            return View();
        }

        public JsonResult JsonData()
        {
            var data = ModelHelper.MultiLineData();
            return Json(data);
        }

        public JsonResult GetRealTimeData()
        {
            RealTimeData data = new RealTimeData
            {
                TimeStamp = DateTime.Now,
                DataValue = rdn.Next(0, 11)
            };
            return Json(data);
        }
    }

    public class RealTimeData
    {
        public DateTime TimeStamp { get; set; }
        public double DataValue { get; set; }
    }
}