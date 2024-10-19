using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using hbd_Em.Models;

namespace hbd_Em.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    public IActionResult FactNumOne()
    {
        return View();
    }
    public IActionResult FactNumTwo()
    {
        return View();
    }
    public IActionResult FactNumThree()
    {
        return View();
    }
    public IActionResult FactNumFour()
    {
        return View();
    }
    public IActionResult FactNumFive()
    {
        return View();
    }
    public IActionResult FactNumSix()
    {
        return View();
    }
    public IActionResult FinalFact()
    {
        return View();
    }

   
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
