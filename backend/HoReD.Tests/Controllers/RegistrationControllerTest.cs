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
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace HoReD.Tests.Controllers
{

<<<<<<< HEAD
    //[TestFixture]
    //public class RegistrationControllerTest
    //{
    //    Mock<IUserService> mock;

    //    [SetUp]
    //    public void SetUp()
    //    {
    //        mock = new Mock<IUserService>();
    //    }

    //    [Test]
    //    public void CreateNewUser_ReturnOK()
    //    {
    //        var controller=new RegistrationController();
    //        var model = GetFakeBindingModel();
    //        IHttpActionResult result = controller.CreateNewUser(model);
    //        var contentResult = result as NegotiatedContentResult<RegistrationBindingModel>;
    //        //Assert.IsNotNull(result);
    //        Assert.AreEqual(HttpStatusCode.Accepted, contentResult.StatusCode);
    //        //Assert.That(() => controller.CreateNewUser(model),
    //        //    Throws.TypeOf<NullReferenceException>());

    //        //Assert.IsNotNull(contentResult.Content);

    //    }

    //    [Test]
    //    public void CreateNewUser_Email_IsValid()
    //    {
    //        var model = new RegistrationBindingModel()
    //        {
    //            FirstName = "TestFirstname",
    //            LastName = "testLastname",
    //            Email = "",
    //            Password = "testPassword",
    //            Phone = "testPhone"
    //        };
    //        var controller = new RegistrationController();
    //        var result = controller.CreateNewUser(model);
    //        Assert.IsInstanceOf<UnauthorizedResult>(result);
    //    }
=======
    [TestFixture]
    public class RegistrationControllerTest
    {
        Mock<IUserService> moq;
        private IUserService moqService;
        private RegistrationController controller;

        [SetUp]
        public void SetUp()
        {
            moq = new Mock<IUserService>();
            moq.Setup(s => s.StoringInfoAboutNewUser(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()));
            moqService = moq.Object;
            controller= new RegistrationController(moqService);

        }

        [Test]
        public void CreateNewUser_ReturnOK()
        {
            var model = GetFakeBindingModel();
            var result = controller.CreateNewUser(model);

            Assert.IsInstanceOf<OkResult>(result);
        }

        [Test]
        public void CreateNewUser_FName_IsInValid()
        {
            var model = new RegistrationBindingModel()
            {
                FirstName = "t",
                LastName = "testLastName",
                Email = "olya@ukr.net",
                Password = "testPassword1$",
                Phone = "0639639999"
            };

            var validationContext = new ValidationContext(model, null, null);
            var validationResults = new List<ValidationResult>();
            Validator.TryValidateObject(model, validationContext, validationResults,true);
            foreach (var validationResult in validationResults)
            {
                controller.ModelState.AddModelError(validationResult.MemberNames.First(), validationResult.ErrorMessage);
            }

            Assert.IsFalse(controller.ModelState.IsValid);
        }

        [Test]
        public void CreateNewUser_LName_IsInValid()
        {
            var model = new RegistrationBindingModel()
            {
                FirstName = "testFirstName",
                LastName = "t",
                Email = "olya@ukr.net",
                Password = "testPassword1$",
                Phone = "0639639999"
            };

            var validationContext = new ValidationContext(model, null, null);
            var validationResults = new List<ValidationResult>();
            Validator.TryValidateObject(model, validationContext, validationResults, true);
            foreach (var validationResult in validationResults)
            {
                controller.ModelState.AddModelError(validationResult.MemberNames.First(), validationResult.ErrorMessage);
            }

            Assert.IsFalse(controller.ModelState.IsValid);
        }

        [Test]
        public void CreateNewUser_Email_IsValid()
        {
            var model = new RegistrationBindingModel()
            {
                FirstName = "testFirstName",
                LastName = "testLastName",
                Email = "olya@ukr.net",
                Password = "testPassword1$",
                Phone = "0639639999"
            };

            var validationContext = new ValidationContext(model, null, null);
            var validationResults = new List<ValidationResult>();
            Validator.TryValidateObject(model, validationContext, validationResults,true);
            foreach (var validationResult in validationResults)
            {
                controller.ModelState.AddModelError(validationResult.MemberNames.First(), validationResult.ErrorMessage);
            }

            Assert.IsTrue(controller.ModelState.IsValid);
        }

        [Test]
        public void CreateNewUser_Email_IsInvalid()
        {
            var model = new RegistrationBindingModel()
            {
                FirstName = "testFirstName",
                LastName = "testLastName",
                Email = "rgnn@ukr",
                Password = "testPassword1$",
                Phone = "0639639999"
            };

            var validationContext = new ValidationContext(model, null, null);
            var validationResults = new List<ValidationResult>();
            Validator.TryValidateObject(model, validationContext, validationResults,true);
            foreach (var validationResult in validationResults)
            {
                controller.ModelState.AddModelError(validationResult.MemberNames.First(), validationResult.ErrorMessage);
            }

            Assert.IsFalse(controller.ModelState.IsValid);
        }

        [Test]
        public void CreateNewUser_Password_IsInvalid()
        {
            var model = new RegistrationBindingModel()
            {
                FirstName = "testFirstName",
                LastName = "testLastName",
                Email = "rgnn@ukr.net",
                Password = "invalidPassword",
                Phone = "0639639999"
            };

            var validationContext = new ValidationContext(model, null, null);
            var validationResults = new List<ValidationResult>();
            Validator.TryValidateObject(model, validationContext, validationResults, true);
            foreach (var validationResult in validationResults)
            {
                controller.ModelState.AddModelError(validationResult.MemberNames.First(), validationResult.ErrorMessage);
            }

            Assert.IsFalse(controller.ModelState.IsValid);
        }

        [Test]
        public void CreateNewUser_Password_IsValid()
        {
            var model = new RegistrationBindingModel()
            {
                FirstName = "testFirstName",
                LastName = "testLastName",
                Email = "rgnn@ukr.net",
                Password = "invalidPassword1",
                Phone = "0639639999"
            };
            var validationContext = new ValidationContext(model, null, null);
            var validationResults = new List<ValidationResult>();
            Validator.TryValidateObject(model, validationContext, validationResults, true);
            foreach (var validationResult in validationResults)
            {
                controller.ModelState.AddModelError(validationResult.MemberNames.First(), validationResult.ErrorMessage);
            }

            Assert.IsTrue(controller.ModelState.IsValid);
        }
>>>>>>> b620b13813df5b9f3de5b453be31a55794ece4fe

        [Test]
        public void CreateNewUser_Phone_IsInvalid()
        {
            var model = new RegistrationBindingModel()
            {
                FirstName = "testFirstName",
                LastName = "testLastName",
                Email = "rgnn@ukr.net",
                Password = "testPassword1$",
                Phone = "0639637"
            };
            var validationContext = new ValidationContext(model, null, null);
            var validationResults = new List<ValidationResult>();
            Validator.TryValidateObject(model, validationContext, validationResults,true);
            foreach (var validationResult in validationResults)
            {
                controller.ModelState.AddModelError(validationResult.MemberNames.First(), validationResult.ErrorMessage);
            }

            Assert.IsFalse(controller.ModelState.IsValid);
        }

        [Test]
        public void CreateNewUser_Phone_IsValid()
        {
            var model = new RegistrationBindingModel()
            {
                FirstName = "testFirstName",
                LastName = "testLastName",
                Email = "rgnn@ukr.net",
                Password = "testPassword1",
                Phone = "0639639999"
            };
            var validationContext = new ValidationContext(model, null, null);
            var validationResults = new List<ValidationResult>();
            Validator.TryValidateObject(model, validationContext, validationResults, true);
            foreach (var validationResult in validationResults)
            {
                controller.ModelState.AddModelError(validationResult.MemberNames.First(), validationResult.ErrorMessage);
            }

            Assert.IsTrue(controller.ModelState.IsValid);
        }

<<<<<<< HEAD
    //    public RegistrationBindingModel GetFakeBindingModel()
    //    {
    //        var testParameter = new RegistrationBindingModel()
    //        {
    //            FirstName = "TestFirstname",
    //            LastName = "TestLastname",
    //            Email = "testEmail@ukr.net",
    //            Password = "testPassword1$",
    //            Phone = "0639637918"
    //        };
    //        return testParameter;
    //    }
    //}
=======
        public RegistrationBindingModel GetFakeBindingModel()
        {
            var testParameter = new RegistrationBindingModel()
            {
                FirstName = "testFirstName",
                LastName = "testLastName",
                Email = "olya@ukr.net",
                Password = "testPassword1$",
                Phone = "0639639999"
            };
            return testParameter;
        }
    }
>>>>>>> b620b13813df5b9f3de5b453be31a55794ece4fe
}
