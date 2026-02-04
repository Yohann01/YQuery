using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YQuery.Shared.Model;

namespace YQuery.Infrastructure
{
    public class BaseDataAccess
    {


        private DBCredentials dBCredentials = new DBCredentials();
        public string baseConnectionString;
        public string dBConnectionString;


        public BaseDataAccess(DBCredentials pDBCredentials) 
        {
            this.dBCredentials = pDBCredentials;
            this.baseConnectionString = InitializeBaseConnectionString();
            this.dBConnectionString = InitializeDBConnectionString();
        }

        protected string GetBaseConnectionString()
        {
            return this.baseConnectionString;
        }        
        
        protected string GetDBConnectionString()
        {
            return this.dBConnectionString;
        }

        private string InitializeBaseConnectionString()
        {
            return $"Server={dBCredentials.SeverName};User Id={dBCredentials.UserId};Password={dBCredentials.Password};TrustServerCertificate=true;";
        }

        private string InitializeDBConnectionString()
        {
            return $"Data Source={dBCredentials.SeverName};Initial Catalog={dBCredentials.DatabaseName};User Id={dBCredentials.UserId};Password={dBCredentials.Password};Trusted_Connection=true; TrustServerCertificate=true; Integrated Security=false;Command Timeout=3000";
        }
    }
}
