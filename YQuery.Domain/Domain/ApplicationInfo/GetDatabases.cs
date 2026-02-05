using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YQuery.Domain.Model;

namespace YQuery.Domain.Domain.ApplicationInfo
{
    public class GetDatabases : BaseApplicationInfo
    {
        private List<string> databases;
        private string errorMessage;


        public GetDatabases(List<IInfraAccess> pInfraAccess) : base(pInfraAccess)
        {
        }

        public async Task<(List<string>, string)> GetDatabasesAsync()
        {
            await this.Initialize();

            return (this.databases, this.errorMessage);
        }

        private async Task Initialize()
        {
            (this.databases, this.errorMessage) = await this.InfraApplicationInfo.GetDatabasesAsync();
            
        }
    }
}
