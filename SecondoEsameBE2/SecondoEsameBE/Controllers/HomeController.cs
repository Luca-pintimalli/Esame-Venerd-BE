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
    private readonly IWebHostEnvironment _env;


    public HomeController(ILogger<HomeController> logger, IArticleService articleService, IWebHostEnvironment env)
    {
        _logger = logger;
        _articleService = articleService;
        _env = env;

    }

    public IActionResult Index()
    {
        var articles = _articleService.GetAll().OrderByDescending(a => a.Price);
        return View(articles);
    }

    public IActionResult Create()
    {
        return View(new Article());

    }


    public IActionResult CreateArticle()
    {
        return View(new ArticleInput());
    }



    [HttpPost]
    public IActionResult CreateArticle(ArticleInput article)
    {
        var a = new Article { Description = article.Description, Name = article.Name, Price = article.Price };
        _articleService.Create(a);

        string uploads = Path.Combine(_env.WebRootPath, "images");


        if (article.Immagine.Length > 0)
        {
            string filePath = Path.ChangeExtension(Path.Combine(uploads, a.Id.ToString()), "jpg");
            using Stream fileStream = new FileStream(filePath, FileMode.Create);
            article.Immagine.CopyTo(fileStream);

        }
        return RedirectToAction(nameof(Index));
    }

    [HttpPost]
    public IActionResult Create(Article article)
    {

        _articleService.Create(article);
        return RedirectToAction(nameof(Index));

    }



    public IActionResult Details(int id)
    {
        var article = _articleService.GetById(id);
       

        string uploads = Path.Combine(_env.WebRootPath, "images");
        var immagine = Path.ChangeExtension(Path.Combine(uploads, article.Id.ToString()), "jpg");
        if (System.IO.File.Exists(immagine))
        {
            ViewBag.Immagine = $"/images/{article.Id}.jpg";
        }

        return View(article);
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

