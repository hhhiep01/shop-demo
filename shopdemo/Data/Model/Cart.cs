namespace shopdemo.Data.Model
{
    public class Cart
    {
        public int Id { get; set; }
        public string TotalPrice  { get; set; }


        public User User { get; set; }  

        public List<Cart_Item> Cart_Items { get; set; }

    }
}
