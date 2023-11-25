using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using shopdemo.Data.Model;
using shopdemo.Data.Services;
using shopdemo.Data.ViewModels;

namespace shopdemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        public ItemsService _itemsService;
        public ItemsController(ItemsService itemsService) 
        { 
            _itemsService = itemsService;
        }
        [HttpPost]
        public IActionResult AddItem([FromBody]ItemVM item)
        {
            _itemsService.AddItem(item);
            return Ok();
        }

        [HttpGet("get-all-items")]
        public IActionResult GetAllItems()
        {
            var allItems = _itemsService.GetAllItems(); 
            return Ok(allItems);
        }

        [HttpGet("get-all-items-by-id/{id}")]
        public IActionResult GetItemsById(int id)
        {
            var item = _itemsService.GetItemById(id);
            return Ok(item);
        }

        [HttpPut("update-item-by-id/{id}")]
        public IActionResult UpdateItemById(int id, [FromBody]ItemVM item)
        {
            var updateItem = _itemsService.UpdateItemById(id,item);
            return Ok(updateItem);
        }

        [HttpDelete("delete-item-by-id/{id}")]
        public IActionResult DeleteItemById(int id) 
        { 
            _itemsService.DeleteItemById(id);
            return Ok();
        }


    }
}
