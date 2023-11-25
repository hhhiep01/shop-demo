using shopdemo.Data.Model;

namespace shopdemo.Request.Cart
{
    public class CartRequest
    {
        public int UserId { get; set; } 
        public List<int> CartItemIds { get; set; }  
    }
}
