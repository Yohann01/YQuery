using Microsoft.Data.SqlClient;
using System;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YQuery.Domain.Domain.ApplicationInfo;
using YQuery.Shared.Model;

namespace YQuery.Service.Service
{
    public class ConnectionService : BaseInfraAccessFactory, IConnectionService
    {

        private GetDatabases getDatabases ;

        public ConnectionService(IRegisterInfraAccess registerInfraAccess) : base(registerInfraAccess)
        {
            getDatabases = new GetDatabases(this.infraAccesses);
        }



        public async Task<(List<string>, string errorMessage)> GetDatabasesAsync()
        {
            string errorMessage = string.Empty;
            var databases = new List<string>();

            try
            {
                return (databases, errorMessage) = await this.getDatabases.GetDatabasesAsync();

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
