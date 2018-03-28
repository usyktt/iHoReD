using System;
using System.Collections.Generic;

namespace HoReD_Entts.Services
{
    public interface IDbContext : IDisposable
    {
        string ExecuteSqlQuery(string cmd, char separatedChar, Dictionary<string, object> param);
        void OpenConnection();
    }
}
