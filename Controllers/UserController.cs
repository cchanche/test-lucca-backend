using Microsoft.AspNetCore.Mvc;
using Payments.Entities;

namespace Payments.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{

  private readonly ILogger<UserController> _logger;

  public UserController(ILogger<UserController> logger)
  {
    _logger = logger;
  }

}
