using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Entities.Services;

namespace HoReD.Controllers
{
    public class ProfessionsController : ApiController
    {
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
