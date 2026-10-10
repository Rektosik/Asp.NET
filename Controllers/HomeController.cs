using Microsoft.AspNetCore.Mvc;
using OrderSystem.Services;

namespace OrderSystem.Controllers;

public class HomeController : Controller
{
    private readonly IGreetingService _greetingService;

    public HomeController(IGreetingService greetingService)
    {
        _greetingService = greetingService;
    }

    public IActionResult Index()
    {
        ViewData["Greeting"] = _greetingService.GetGreeting();
        return View();
    }

    public IActionResult About()
    {
        return View();
    }
}