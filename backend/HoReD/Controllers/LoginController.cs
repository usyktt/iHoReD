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
        [Route("LoginUser")]
        [HttpPost]
        [HttpGet]
        [AllowAnonymous]
        
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
                currentUser = user.GetUserInfo("izhydchukdoc", "hgKJ7&hjv*");
                return Ok(currentUser);
            }
            catch (Exception)
            {
                return Unauthorized();
            }
        }
    }
}
