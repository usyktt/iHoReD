using System;
using System.Collections.Generic;
using System.Web.Http;
using Entities;
using Entities.Services;

namespace HoReD.Controllers
{
    /// <summary>
    /// Controller that represents information about Doctors
    /// </summary>
    public class DoctorController : ApiController
    {
        private readonly IDoctorService _doctorService;

        public DoctorController()
        {
            _doctorService = new DoctorService(new DbContext());
        }
        public DoctorController(IDoctorService doctorService)
        {
            _doctorService = doctorService;
        }

        /// <summary>
        /// Gets full infiormation about Doctors in database
        /// </summary>
        /// <returns>List of instances of the class DoctorInfo</returns>
        /// <example>http://localhost:*****/api/Doctor/</example>
        [HttpGet]
        public List<DoctorInfo> GetDoctors()
        {
            return _doctorService.GetDoctors();
        }

        [HttpGet]
        [Route("GetDoctors/{profession}")]
        public List<string[]> GetDoctorsByProfession(string profession)
        {
            return _doctorService.GetDoctorsByProfession(profession);
        }

        [HttpGet]
        [ActionName("GetProfessions")]
        [Route("ProfessionsStatic/{isStatic=true}")]
        [Route("ProfessionsNotStatic/{isStatic=false}")]
        public List<string> GetProfessions(bool isStatic)
        {
            var dbContext = new DbContext();
            var doctorService = new DoctorService(dbContext);
            return doctorService.GetProfessions(isStatic);
        }

    }
}
