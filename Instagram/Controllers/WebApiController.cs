using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Instagram.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class WebApiController : ControllerBase
    {
        public IActionResult Index()
        {
            return Ok();
        }

        public IActionResult Create()
        {
            return Ok();
        }

        public IActionResult Update()
        {
            return Ok();
        }

        public IActionResult Delete()
        {
            return Ok();
        }

    }
}
