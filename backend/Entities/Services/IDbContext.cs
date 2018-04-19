﻿using System;
using System.Collections.Generic;

namespace Entities.Services
{
    public interface IDbContext : IDisposable
    {
        string ExecuteSqlQuery(string cmd, char separatedChar, Dictionary<string, object> param);
        void OpenConnection();
        void Insert(string cmd, IDictionary<string, string> usersInfo);
    }
}
