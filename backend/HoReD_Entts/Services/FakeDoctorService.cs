using System;
using System.Collections.Generic;
using System.Text;

namespace HoReD_Entts.Services
{
    public class FakeDoctorService: IDoctorService
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

        public List<string> GetProfessions(bool isStatic)
        {
            return new List<string>();
        }

        public List<string[]> GetDoctorsByProfession(string profession)
        {
            var list = new List<string[]>();
            return list;
        }
    }
}
