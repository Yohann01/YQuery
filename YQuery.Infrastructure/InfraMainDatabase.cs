using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YQuery.Domain.Model;
using YQuery.Infrastructure.ApplicationInfo;
using YQuery.Shared.Model;

namespace YQuery.Infrastructure
{
    public class InfraMainDatabase : IInfraAccess, IInfraMainDatabase
    {
        private DBCredentials _dBCredentials;
        private readonly IInfranstructureApplicationInfo _infranstructureApplicationInfo;


        public IInfranstructureApplicationInfo InfranstructureApplicationInfo { get { return this._infranstructureApplicationInfo; } }

        public InfraMainDatabase(DBCredentials dBCredentials)
        {
            this._dBCredentials = dBCredentials;
            this._infranstructureApplicationInfo = new InfrastructureApplicationInfo(this._dBCredentials);
        }
    }
}
