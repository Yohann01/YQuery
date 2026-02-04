using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YQuery.Domain.Model;
using YQuery.Shared.Model;

namespace YQuery.Infrastructure.ApplicationInfo
{
    public class InfrastructureApplicationInfo : BaseDataAccess, IInfranstructureApplicationInfo
    {
        public InfrastructureApplicationInfo(DBCredentials pDBCredentials) : base(pDBCredentials)
        {

        }


        public async Task<(List<string>, string errorMessage)> GetDatabasesAsync()
        {
            string errorMessage = string.Empty;
            var databases = new List<string>();

            try
            {
                using var conn = new SqlConnection(this.GetBaseConnectionString());
                await conn.OpenAsync();

                using var cmd = new SqlCommand("SELECT name FROM sys.databases WHERE state_desc='ONLINE' ORDER BY name", conn);
                using var reader = await cmd.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                    databases.Add(reader.GetString(0));

                return (databases, errorMessage);
            }
            catch (SqlException ex)
            {
                return (null, ex.Message.ToString())!;
            }
            catch (Exception ex)
            {
                return (null, ex.Message.ToString())!;
            }
        }
    }
}
