using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMvcHtmx.Features.Home;

public class HomeController : Controller
{
  private readonly ILogger<HomeController> _logger;

  public HomeController(
    ILogger<HomeController> logger
  )
  {
    _logger = logger;
  }

  public IActionResult Index()
  {
    return View("~/Features/Home/Index.cshtml");
  }
}
