using HoReD_Entts;
using System;
using System.Collections.Generic;
using System.Web.Http;
using HoReD_Entts.Services;

namespace HoReD.Controllers
{
    /// <summary>
    /// Controller that represents information about Doctors
    /// </summary>
    public class DoctorController : ApiController
    {
        /// <summary>
        /// Gets full infiormation about Doctors in database
        /// </summary>
        /// <returns>List of instances of the class DoctorInfo</returns>
        /// <example>http://localhost:*****/api/Doctor/</example>
        [HttpGet]
        public List<DoctorInfo> GetDoctors()
        {
            var dbContext = new DbContext();
            var doctorService = new DoctorService(dbContext);
            return doctorService.GetDoctors();
        }

        [HttpGet]
        [Route("GetDoctors/{profession}")]
        public List<string[]> GetDoctorsByProfession(string profession)
        {
            var dbContext = new DbContext();
            var doctorService = new DoctorService(dbContext);
            return doctorService.GetDoctorsByProfession(profession);
        }

    }
}
