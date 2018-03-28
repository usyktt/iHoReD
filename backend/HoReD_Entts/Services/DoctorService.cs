using System;
using System.Collections.Generic;

namespace HoReD_Entts.Services
{
    public class DoctorService : IDoctorService
    {
        private readonly IDbContext _dbContext;

        public DoctorService(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public List<DoctorInfo> GetDoctors()
        {
            const string cmd = "GETINFOABOUTDOCTORS";
            var param=new Dictionary<string,object>();
            var str = _dbContext.ExecuteSqlQuery(cmd, '*',param);
            var values = str.Split('*');
            var list = new List<DoctorInfo>();
            for (int i = 0; i < (values.Length-1); i+=8)
            {
                var doctor = new DoctorInfo
                {
                    Id = Convert.ToInt32(values.GetValue(0 + i)),
                    FirstName = values.GetValue(1 + i).ToString(),
                    LastName = values.GetValue(i + 2).ToString(),
                    ProfessionName = values.GetValue(i + 3).ToString(),
                    StartHour = TimeSpan.Parse(values.GetValue(i + 4).ToString()),
                    EndHour = TimeSpan.Parse(values.GetValue(i + 5).ToString()),
                    EmployingDate = Convert.ToDateTime(values.GetValue(i + 6).ToString()),
                    Image = values.GetValue(i + 7).ToString()
                };
                list.Add(doctor);

            }
            _dbContext.Dispose();
            return list;
        }

        public List<string> GetProfessions(bool isStatic)
        {
            const string cmd = "Get_List_Professions";
            var param = new Dictionary<string, object>()
            {
                {"@Is_Static", isStatic}
            };
            var str = _dbContext.ExecuteSqlQuery(cmd, '*',param);
            var values = str.Split('*');
            var list = new List<string>();
            for (int i = 0; i < values.Length; i ++)
            {
                list.Add(values.GetValue(i).ToString());

            }
            _dbContext.Dispose();
            return list;
        }

        public List<string[]> GetDoctorsByProfession(string profession)
        {
            const string cmd = "Get_Doctors_With_Some_Profession";
            var param = new Dictionary<string, object>()
            {
                {"@Profession_Name", profession}
            };
            var str = _dbContext.ExecuteSqlQuery(cmd, '*', param);
            var values = str.Split('*');
            var list = new List<string[]>();
            for (int i = 0; i < (values.Length-1); i+=2)
            {
                string[] name = {values.GetValue(0+i).ToString(), values.GetValue(1+i).ToString()};
                list.Add(name);

            }
            _dbContext.Dispose();
            return list;
        }
    }
}
