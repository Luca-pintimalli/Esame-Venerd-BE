using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SecondoEsameBE.Entities;
using SecondoEsameBE.Models;
using SecondoEsameBE.Services;

namespace SecondoEsameBE.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IArticleService _articleService;

    public HomeController(ILogger<HomeController> logger, IArticleService articleService)
    {
        _logger = logger;
        _articleService = articleService;
    }

    public IActionResult Index()
    {
        var articles = _articleService.GetAll().OrderByDescending(a => a.Price);
        return View(articles);
    }

    public IActionResult Article()
    {
        return View(new Article());
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

