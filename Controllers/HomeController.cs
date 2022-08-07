using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Dojo_Survey_With_Validation.Models;

namespace Dojo_Survey_With_Validation.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Privacy()
    {
        return View();
    }


}
