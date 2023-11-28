using Microsoft.AspNetCore.Mvc;

namespace AppApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SettingController : ControllerBase
    {
        private readonly ILogger<SettingController> _logger;
        private readonly IConfiguration _configuration;

        public SettingController(ILogger<SettingController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_configuration["ClientSecret"]);
        }

    }
}
