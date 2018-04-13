using System;
using System.Text;
using System.Collections.Generic;
using HoReD.Controllers;
using Entities;
using Entities.Services;
using NUnit.Framework;
using Moq;
using HoReD;
using HoReD.Models;

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
            /*bool stat = false;
            var fake_list = GetFakeBindingModel();
            mock.Setup(repo => repo.CreateNewUser(stat)).Returns(fake_list);
            var controller = new DoctorController(mock.Object);

            // Act
            var result = controller.GetProfessions(stat);*/
        }

        public RegistrationBindingModel GetFakeBindingModel()
        {
            var testParameter = new RegistrationBindingModel()
            {
                FirstName = "testFirstname",
                LastName = "testLastname",
                Email = "testEmail",
                Password = "testPassword"
            };
            return testParameter;
        }
    }
}
