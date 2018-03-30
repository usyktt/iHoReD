using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Services
{
    public class UserService : IUserService
    {
        private readonly IDbContext _dbContext;

        public UserService(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void StoringInfoAboutNewUser(string firstname, string lastname, string email, string password)
        {
            var regInfo = new Dictionary<string, string>()
            {
                { "FIRSTNAME", firstname},
                { "LASTNAME", lastname},
                { "EMAIL", email},
                { "PASSWORD", password},
            };
            var cmd = $"insert into USERS(FIRSTNAME, LASTNAME, IDROLE, EMAIL, PASSWORD) values(@firstname, @lastname, 3, @email, @password)";

            _dbContext.InsertNewUser(cmd, regInfo);
        }
    }
}
