using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using shopdemo.Data.Model;
using shopdemo.Request.Cart;

namespace shopdemo.Data.Services
{
    public class CartsService
    {
        private AppDbContext _context;

        public CartsService(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddItemToCart(CartRequest cartRequest)
        {
            var listItem = await _context.Items.
                                 Where(x => cartRequest.CartItemIds.Contains(x.Id)).
                                 ToListAsync(); 
            
        }
    }
}
