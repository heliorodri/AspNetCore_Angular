using DattingApp.API.Models;
using System.Threading.Tasks;

namespace DattingApp.API.Data
{
    public class AuthRepository : IAuthRepository
    {
        private readonly DataContext _context;
        public AuthRepository(DataContext context)
        {
            this._context = context;
        }
        
        public Task<User> Login(string username, string password)
        {
            throw new System.NotImplementedException();
        }

        public Task<User> Register(User user, string password)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> UserExistis(string username)
        {
            throw new System.NotImplementedException();
        }
    }
}