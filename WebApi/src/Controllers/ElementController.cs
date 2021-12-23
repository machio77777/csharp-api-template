using Microsoft.AspNetCore.Mvc;
using WebApi.src.UseCases;

namespace WebApi.src.Controllers;

[ApiController]
[Route("[controller]")]
public class ElementController : ControllerBase
{
    private readonly ILogger<ElementController> _logger;
    private readonly IGetElementUseCase _getElementUseCase;

    public ElementController(ILogger<ElementController> logger, IGetElementUseCase getElementUseCase)
    {
        _logger = logger;
        _getElementUseCase = getElementUseCase;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        try
        {
            var elements = _getElementUseCase.GetAll();
            return Ok(new { Elements = elements });
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "予期せぬエラーが発生しました。");
            return Problem();
        }
    }
}