using AWSFargateTestApi.Application.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AWSFargateTestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AWSFargateTestController : ControllerBase
    {
        private readonly AWSFargateTestService _awsFargateTestService;

        public AWSFargateTestController(AWSFargateTestService awsFargateTestService)
        {
            _awsFargateTestService = awsFargateTestService;
        }
        
        [HttpGet]
        public string Get()
        {
            return _awsFargateTestService.GetTestMessage();
        }
    }
}