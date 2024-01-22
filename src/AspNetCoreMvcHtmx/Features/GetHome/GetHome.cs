using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMvcHtmx.Features.GetHome;

public class GetHomeController(ILogger<GetHomeController> logger) : Controller
{
  private readonly ILogger<GetHomeController> _logger = logger;

  public IActionResult GetHome() => View();
}
