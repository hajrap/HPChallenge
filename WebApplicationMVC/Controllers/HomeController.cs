using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebApplicationMVC.Models;

namespace WebApplicationMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<DataModel.RootObject> data = new List<DataModel.RootObject>();
            DataModel.RootObject rootObject = GetData();
            data.Add(rootObject);
            return View(data);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public DataModel.RootObject GetData()
        {

            try
            {
               return JsonConvert.DeserializeObject<DataModel.RootObject>(System.IO.File.ReadAllText(@"Data\Wolferhampton_Race.json"));
            }
            catch (Exception ex) { 
            throw ex;
            }

        }
    }
}
