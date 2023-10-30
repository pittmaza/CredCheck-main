using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CredCheck.Models;

namespace CredCheck.Controllers;

public class HomeController : Controller
{
    bool flag = false;

    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Home()
    {
        //Stating the value of "flag"
        ViewBag.flagvalue = flag;
        return View();
    }

    public IActionResult Education()
    {
        return View();
    }

    public IActionResult BruteForce()
    {
        return View();
    }

    public IActionResult Phishing()
    {
        return View();
    }

    public IActionResult Keylogging()
    {
        return View();
    }

    public IActionResult Statistics()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    [HttpPost]
    public IActionResult Home(IFormCollection frm)
    {
        //Since we now want to display this collection, flag is true
        flag = true;
        ViewBag.flagvalue = flag;
        ViewBag.EmailAddress = frm["EmailAddress"].ToString();
        ViewBag.Password = frm["Password"].ToString();
        return View();
    }
}

