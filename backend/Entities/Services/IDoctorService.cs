﻿using System.Collections.Generic;

namespace Entities.Services
{
    public interface IDoctorService
    {
        List<DoctorInfo> GetDoctors();

        List<string[]> GetProfessions(bool isStatic);

        List<string[]> GetDoctorsByProfession(string profession);
        List<string[]> GetDoctorsByProfessionId(int professionId);
        List<string[]> GetDoctorSchedule(int doctorId);
    }
}
