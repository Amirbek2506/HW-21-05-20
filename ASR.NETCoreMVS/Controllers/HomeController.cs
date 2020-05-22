using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using ASR.NETCoreMVS.Models.Persons;

namespace ASR.NETCoreMVS.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(int? Id)
        { 
            return View(new ConnectionDataPersons().GetInfoPersons());
        }
    }
}