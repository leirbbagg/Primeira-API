using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SegundaAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : Controller
    {
        [HttpGet]
        // GET: api/TestController
        public ActionResult Get()
        {
            return View();
        }
    }
}
