namespace shopdemo.Data.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public int Age { get; set; }

        public string Adress { get; set; }

        public string PhoneNumber { get; set; }
        

        public int CartId { get; set; } 
        public Cart Cart { get; set; }
    }
}
