using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using shopdemo.Data.Services;

namespace shopdemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartsController : ControllerBase
    {
        public CartsService _cartsService;
        public CartsController(CartsService itemsService)
        {
            _cartsService = itemsService;
        }



    }
}
