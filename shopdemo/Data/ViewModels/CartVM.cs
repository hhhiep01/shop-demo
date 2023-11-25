using shopdemo.Data.Model;

namespace shopdemo.Data.ViewModels
{
    public class CartVM
    {
        public string TotalPrice { get; set; }


        public int UserId { get; set; }
        public User User { get; set; }

        public List<Cart_Item> Cart_Items { get; set; }
    }
}
