using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;

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
            var password_hash = Hashing.HashingPassword(password);

            var regInfo = new Dictionary<string, string>()
            {
                { "FIRSTNAME", firstname},
                { "LASTNAME", lastname},
                { "EMAIL", email},
                { "PASSWORD", password_hash},
            };
            var cmd = "REGISTER_USER";

            _dbContext.InsertNewUser(cmd, regInfo);
        }

        public User GetUserInfo(string login, string password)
        {
            const string cmd = "GET_USER_INFO_START_PAGE";
            var param = new Dictionary<string, object>()
            {
                {"@LOGIN", login},
                {"@PASSWORD", password}
            };
            var str = _dbContext.ExecuteSqlQuery(cmd, '*', param);
            var values = str.Split('*');
            var user = new User
                {
                    Id = Convert.ToInt32(values.GetValue(0)),
                    FirstName = values.GetValue(1).ToString(),
                    LastName = values.GetValue(2).ToString(),
                    RoleName = values.GetValue(3).ToString(),
                    Login = values.GetValue(4).ToString(),
                    Password = values.GetValue(5).ToString(),
                    Email = values.GetValue(3).ToString(),
                };

            _dbContext.Dispose();
            return user;
        }
    }
}
