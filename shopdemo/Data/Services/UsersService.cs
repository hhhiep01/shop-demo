using shopdemo.Data.Model;
using shopdemo.Data.ViewModels;

namespace shopdemo.Data.Services
{
    public class UsersService
    {
        private AppDbContext _context;

        public UsersService(AppDbContext context)
        {
            _context = context;
        }
        public void AddUser(UserVM user)
        {
            var _user = new User()
            {
                Name = user.Name,
                Adress = user.Adress,
                Age = user.Age,
                PhoneNumber = user.PhoneNumber,
            };
            _context.Users.Add(_user);
            _context.SaveChanges();
        }

        public List<User> GetAllUser() => _context.Users.ToList();

        public User GetUserById(int userId) 
        {
            return _context.Users.FirstOrDefault(n => n.Id == userId);
        }
    }
}
