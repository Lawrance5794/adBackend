using Microsoft.AspNetCore.Mvc;

namespace AdBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAd()
        {
            return Ok(new { Title = "Ad Title", Content = "This is an advertisement." });
        }
    }
}