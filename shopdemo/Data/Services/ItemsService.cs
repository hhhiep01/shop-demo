using shopdemo.Data.Model;
using shopdemo.Data.ViewModels;

namespace shopdemo.Data.Services
{
    public class ItemsService
    {
        private AppDbContext _context;

        public ItemsService(AppDbContext context)
        {
            _context = context;
        }
        
        public void AddItem(ItemVM item)
        {   
            var existingItem =_context.Items.FirstOrDefault(i => i.Name == item.Name);
            if (existingItem != null)
            {
                existingItem.Quantity += item.Quantity;
            }
            else
            {
                var _item = new Item()
                {
                    Name = item.Name,
                    Price = item.Price,
                    Quantity = item.Quantity,
                };

                _context.Items.Add(_item);
            }
           
            _context.SaveChanges();

           

        }
        public List<Item> GetAllItems()=> _context.Items.ToList();
        public Item GetItemById(int itemId)
        {
            return _context.Items.FirstOrDefault(n => n.Id == itemId);
        }
        public Item UpdateItemById(int itemId, ItemVM item) 
        { 
            var _item = _context.Items.FirstOrDefault(n => n.Id == itemId);  
            if (_item != null)
            {   
                _item.Name = item.Name;
                _item.Price = item.Price;
                _item.Quantity = item.Quantity;

                _context.SaveChanges();
            }
            return _item;

        }

        public void DeleteItemById(int itemId)
        {
            var _item = _context.Items.FirstOrDefault(n => n.Id == itemId);
            if( _item != null )
            {
                _context.Items.Remove(_item);
                _context.SaveChanges();
            }

        }
    }
}
