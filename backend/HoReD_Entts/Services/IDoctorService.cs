using System.Collections.Generic;

namespace HoReD_Entts.Services
{
    public interface IDoctorService
    {
        List<DoctorInfo> GetDoctors();

        List<string> GetProfessions(bool isStatic);

        List<string[]> GetDoctorsByProfession(string profession);
    }
}
