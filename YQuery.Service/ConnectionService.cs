using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YQuery.Shared.Model;

namespace YQuery.Service
{
    public class ConnectionService : IConnectionService
    {
        private readonly UserSession userSession;
        public ConnectionService(UserSession pUserSession)
        {
            this.userSession = pUserSession;
        }

        public async Task<bool> Connect()
        {
            string connectionString = this.InitializeBaseConnectionString();

            try
            {
                using var conn = new SqlConnection(connectionString);
                await conn.OpenAsync(); 
                return true;
            }
            catch (SqlException)
            {
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<List<string>> GetDatabasesAsync()
        {
            using var conn = new SqlConnection(this.InitializeBaseConnectionString());
            await conn.OpenAsync();

            var databases = new List<string>();
            using var cmd = new SqlCommand("SELECT name FROM sys.databases WHERE state_desc='ONLINE' ORDER BY name", conn);
            using var reader = await cmd.ExecuteReaderAsync();
            while (await reader.ReadAsync())
                databases.Add(reader.GetString(0));

            return databases;
        }

        private string InitializeBaseConnectionString()
        {
            var dBCredentials = this.userSession.GetDBCredentials();
            return $"Server={dBCredentials.SeverName};User Id={dBCredentials.UserId};Password={dBCredentials.Password};TrustServerCertificate=true;";
        }

        private string InitializeDBConnectionString()
        {
            var dBCredentials = this.userSession.GetDBCredentials();
            return $"Data Source={dBCredentials.SeverName};Initial Catalog={dBCredentials.DatabaseName};User Id={dBCredentials.UserId};Password={dBCredentials.Password};Trusted_Connection=true; TrustServerCertificate=true; Integrated Security=false;Command Timeout=3000";
        }
    }
}
