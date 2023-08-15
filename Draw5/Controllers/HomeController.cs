using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Draw5.Models;

namespace Draw5.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Index()
    {
        Draw5Model result = Draw5DAL.Draw5();
        if(result.Remaining <= 0)
        {
            Draw5DAL.ShuffleDeck();
        }
        return View();
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
}

