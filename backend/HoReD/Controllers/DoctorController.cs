using HoReD_Entts;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HoReD_Entts.Services;

namespace HoReD.Controllers
{
    /// <summary>
    /// Controller that represents information about Doctors
    /// </summary>
    public class DoctorController : ApiController
    {

        [HttpGet]
        [ActionName("GetDoctorByID")]
        public Doctor Get(int id)
        {
            var dbContext=new DbContext();
            var doctorService=new DoctorService(dbContext);
            return doctorService.GetDoctorById(id);
        }

        /// <summary>
        /// Gets full infiormation about Doctors in database
        /// </summary>
        /// <returns>List of instances of the class DoctorInfo</returns>
        /// <example>http://localhost:*****/api/Doctor/</example>
        [HttpGet]
        [ActionName("GetDoctors")]
        public List<DoctorInfo> GetDoctors()
        {
            var dbContext = new DbContext();
            var doctorService = new DoctorService(dbContext);
            return doctorService.GetDoctors();
        }
    }
}
