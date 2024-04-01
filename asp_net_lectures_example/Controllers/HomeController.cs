using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using asp_net_lectures_example.Models;
using asp_net_lectures_example.Resources;
using Microsoft.Extensions.Localization;

namespace asp_net_lectures_example.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IStringLocalizer<Texts> _localizer;
    
    public HomeController(ILogger<HomeController> logger, IStringLocalizer<Texts> localizer)
    {
        _logger = logger;
        _localizer = localizer;
    }

    public async Task<IActionResult> Index()
    {
        string t = _localizer["Title"].Value;
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
    }
}