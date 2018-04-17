using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Entities;
using Entities.Services;
using HoReD.Models;

namespace HoReD.Controllers
{
    public class LoginController : ApiController
    {
        private readonly IDbContext _dbContext = new DbContext();

        //Adds to system inforation about new user
        
        [HttpPost]        
        public IHttpActionResult LoginUser(LoginUserBindingModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return Conflict();
                }

                IUserService user = new UserService(_dbContext);
                User currentUser = new User();
                currentUser = user.GetUserInfo(model.Email);
                var passwordRegForm = model.Password;
                var isPasswordEqual = Hashing.VerifyPassword(model.Password, currentUser.Password);
                if (isPasswordEqual)
                {
                    return Ok(currentUser);
                }
                else
                {
                    return Unauthorized();
                }
            }
            catch (Exception)
            {
                return Unauthorized();
            }
        }
    }
}
