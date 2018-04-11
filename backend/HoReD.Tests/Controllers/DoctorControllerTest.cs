using System;
using System.Text;
using System.Collections.Generic;
using HoReD.Controllers;
using Entities;
using Entities.Services;
using NUnit.Framework;
using Moq;

namespace HoReDTests.Controllers
{
    /// <summary>
    /// Summary description for DoctorController
    /// </summary>
    [TestFixture]
    public class DoctorControllerTest
    {
        
        public List<DoctorInfo> GetDoctors()
        {
            var list = new List<DoctorInfo>();
            var doctor1 = new DoctorInfo
            {
                Id = 1,
                FirstName = "name1",
                LastName = "name2",
                ProfessionName = "therapist",
                EmployingDate = new DateTime(2018, 12, 25, 10, 30, 50),
                StartHour = new TimeSpan(5, 15, 15),
                EndHour = new TimeSpan(5, 15, 15),
                Image = "1.jpg"
            };
            var doctor2 = new DoctorInfo
            {
                Id = 2,
                FirstName = "name3",
                LastName = "name4",
                ProfessionName = "therapist",
                EmployingDate = new DateTime(2012, 12, 25, 10, 30, 50),
                StartHour = new TimeSpan(5, 15, 15),
                EndHour = new TimeSpan(5, 15, 15),
                Image = "2.jpg"
            };
            list.Add(doctor1);
            list.Add(doctor2);
            return list;
        }

        [Test]
        public void GetDoctors_Count()
        {
            // Arrange
            /*var testData = new FakeDoctorService();
            var controller = new DoctorController(testData); */

            var mock = new Mock<IDoctorService>();
            mock.Setup(repo => repo.GetDoctors()).Returns(GetDoctors());

            var controller = new DoctorController(mock.Object);
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
