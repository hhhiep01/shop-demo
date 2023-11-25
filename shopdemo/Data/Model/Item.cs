namespace shopdemo.Data.Model
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }

        public List<Cart_Item> Cart_Items { get; set; }

    }
}
