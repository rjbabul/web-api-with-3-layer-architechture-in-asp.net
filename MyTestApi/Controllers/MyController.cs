using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyTestApi.Service.Abstraction;

namespace MyTestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyController : ControllerBase
    {
        public readonly IServices _myservice;
        
        public MyController(IServices myservice)
        {
            _myservice = myservice;
        }

        [HttpGet]
        public IActionResult getdata()
        {

            var data = _myservice.getData();


            return Ok(data);
        }
    }
}
