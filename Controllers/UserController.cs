using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Dojo_Survey_With_Validation.Models;

namespace Dojo_Survey_With_Validation.Controllers;

public class UserController : Controller
{
    [ HttpGet( "/login" ) ]
    public IActionResult Login()
    {
        return View( "Login" );
    }

    [ HttpGet( "/success" ) ]
    public IActionResult Success()
    {
        return View( "Success" );
    }

    [HttpPost("/register")]
    public IActionResult Register( User newSurvey )
    {
        if( ModelState.IsValid )
        {
            return RedirectToAction( "Success" );
        }
        return Login();
    }

}
