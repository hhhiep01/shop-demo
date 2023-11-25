namespace shopdemo.Data.Model
{
    public class Cart_Item
    {
        public int Id { get; set; }
        public int Quantity { get; set; }

        public int CartId { get; set; } 
        public int ItemId { get; set; }

        public Cart Cart { get; set; }  

        public Item Item { get; set; }

    }
}
