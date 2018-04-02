using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Entities.Services
{
    public class DbContext : IDbContext
    {
        private readonly SqlConnection _myConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConString"].ConnectionString);

        public DbContext()
        {
                _myConnection.Open();
        }

        //Execute query, which return one string, where values separated by char
        public string ExecuteSqlQuery(string cmd, char separatedChar,Dictionary<string,object> param)
        {
            var result = new StringBuilder();
            using (_myConnection)
            {
                using (var command = new SqlCommand(cmd, _myConnection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    foreach (var item in param)
                    {
                        CommandExtensions.AddParameter(command, item.Key, item.Value);
                    }
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            result.Append(reader.GetValue(i));
                            result.Append(separatedChar);
                        }
                    }

                }
            }
            
            result.Remove(result.Length - 1, 1);
            return result.ToString();
        }

        public void OpenConnection()
        {
            _myConnection.Open();
        }

        public void InsertNewUser(string cmd, IDictionary<string, string> usersInfo)
        {
            using (_myConnection)
            {
                using (var sqlCommand = new SqlCommand(cmd, _myConnection))
                {
                    foreach (var userInfo in usersInfo)
                    {
                        sqlCommand.AddParameter(userInfo.Key,userInfo.Value);
                    }

                    try
                    {
                        sqlCommand.ExecuteNonQuery();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
        }

        public void Dispose()
        {
            _myConnection?.Dispose();
        }
    }
}
