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
            return await this.getDatabases.GetDatabasesAsync();
        }


    }
}
