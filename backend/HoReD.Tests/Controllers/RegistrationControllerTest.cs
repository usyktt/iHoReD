using System;
using System.Text;
using System.Collections.Generic;
using System.Net;
using System.Web.Http;
using HoReD.Controllers;
using Entities;
using Entities.Services;
using NUnit.Framework;
using Moq;
using HoReD;
using HoReD.Models;
using System.Web.Http.Results;


namespace HoReD.Tests.Controllers
{

    [TestFixture]
    public class RegistrationControllerTest
    {
        Mock<IUserService> mock;

        [SetUp]
        public void SetUp()
        {
            mock = new Mock<IUserService>();
        }

        [Test]
        public void CreateNewUser_ReturnOK()
        {
            var controller=new RegistrationController();
            var model = GetFakeBindingModel();
            IHttpActionResult result = controller.CreateNewUser(model);
            var contentResult = result as NegotiatedContentResult<RegistrationBindingModel>;
            //Assert.IsNotNull(result);
            Assert.AreEqual(HttpStatusCode.Accepted, contentResult.StatusCode);
            //Assert.That(() => controller.CreateNewUser(model),
            //    Throws.TypeOf<NullReferenceException>());

            //Assert.IsNotNull(contentResult.Content);

        }

        [Test]
        public void CreateNewUser_Email_IsValid()
        {
            var model = new RegistrationBindingModel()
            {
                FirstName = "TestFirstname",
                LastName = "testLastname",
                Email = "",
                Password = "testPassword",
                Phone = "testPhone"
            };
            var controller = new RegistrationController();
            var result = controller.CreateNewUser(model);
            Assert.IsInstanceOf<UnauthorizedResult>(result);
        }



        public RegistrationBindingModel GetFakeBindingModel()
        {
            var testParameter = new RegistrationBindingModel()
            {
                FirstName = "TestFirstname",
                LastName = "TestLastname",
                Email = "testEmail@ukr.net",
                Password = "testPassword1$",
                Phone = "0639637918"
            };
            return testParameter;
        }
    }
}
