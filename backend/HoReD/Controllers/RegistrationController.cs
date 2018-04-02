using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Entities.Services;
using HoReD.Models;

namespace HoReD.Controllers
{
    public class RegistrationController : ApiController
    {
        private readonly IDbContext _dbContext = new DbContext();

        //Adds to system inforation about new user
        [HttpPost]
        [AllowAnonymous]
        public IHttpActionResult CreateNewUser(RegistrationBindingModel model)
        {
            try
            {
                IUserService user = new UserService(_dbContext);
                user.StoringInfoAboutNewUser(model.FirstName, model.LastName, model.Email, model.Password);
                return Ok();
            }
            catch (Exception)
            {
                return Unauthorized();
            }
            
        }
    }
}