using GetSingleProduct.Data.Dtos;
using GetSingleProduct.Services;
using Microsoft.AspNetCore.Mvc;


namespace GetSingleProduct.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GetSingleProductController : ControllerBase
    {
        MagentoService magentoService;

        public GetSingleProductController(MagentoService magentoService)
        {
            this.magentoService = magentoService;
        }

        [HttpGet("{system}")]
        public IActionResult GetProduct(string system, [FromBody] ReadMagentoDto magentoDto )
        {
            magentoService.GetSingleProduct(system, magentoDto);
            return Ok();
        }
    }
}
