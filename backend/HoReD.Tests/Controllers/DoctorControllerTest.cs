using System;
using System.Text;
using System.Collections.Generic;
using HoReD.Controllers;
using Entities.Services;
using NUnit.Framework;

namespace HoReDTests.Controllers
{
    /// <summary>
    /// Summary description for DoctorController
    /// </summary>
    [TestFixture]
    public class DoctorControllerTest
    {

        [Test]
        public void GetDoctors_Count()
        {
            // Arrange
            var testData = new FakeDoctorService();
            var controller = new DoctorController(testData);

            // Act
            var response = controller.GetDoctors();

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual(response.Count, 2);
        }

        [Test]
        public void GetDoctors_ValidValues()
        {
            // Arrange
            var testData = new FakeDoctorService();
            var controller = new DoctorController(testData);

            // Act
            var response = controller.GetDoctors();

            // Assert
            Assert.AreEqual(response[0].FirstName, "name1");
            Assert.AreEqual(response[0].LastName, "name2");
            Assert.AreEqual(response[0].ProfessionName, "therapist");
        }

        [Test]
        public void GetDoctorsByProffesion_ValidValues()
        {
            // Arrange
            var testData = new FakeDoctorService();
            var controller = new DoctorController(testData);
            string prof = "therapist";

            // Act
            var response = controller.GetDoctorsByProfession(prof);

            // Assert
            Assert.AreEqual(response[0][0].ToString(), "Halenok");
            Assert.AreEqual(response[0][1].ToString(), "Iryna");
            Assert.AreEqual(response[1][0].ToString(), "Solyar");
            Assert.AreEqual(response[1][1].ToString(), "Olya");
        }
        [Test]
        public void GetDoctorsByProffesion_Count()
        {
            // Arrange
            var testData = new FakeDoctorService();
            var controller = new DoctorController(testData);
            string prof = "therapist";

            // Act
            var response = controller.GetDoctorsByProfession(prof);

            // Assert
            Assert.AreEqual(response.Count, 2);
        }
    }
}
