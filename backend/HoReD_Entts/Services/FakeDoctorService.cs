using System;
using System.Collections.Generic;
using System.Text;

namespace HoReD_Entts.Services
{
    public class FakeDoctorService: IDoctorService
    {
        public Doctor GetDoctorById(int id)
        {
            Doctor doctor = new Doctor
            {
                Id = 1,
                IdProfession = 1,
                StartHour = new TimeSpan(5,15,15),
                EndHour = new TimeSpan(5, 15, 15),
                EmployingDate = new DateTime(2018, 12, 25, 10, 30, 50),
                Image = "1.jpg"
            };
            return doctor;
        }

        public List<DoctorInfo> GetDoctors()
        {
            List<DoctorInfo> list = new List<DoctorInfo>();
            DoctorInfo doctor1 = new DoctorInfo
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
            DoctorInfo doctor2 = new DoctorInfo
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
    }
}
