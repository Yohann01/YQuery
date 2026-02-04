using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YQuery.Shared.Model;

namespace YQuery.Service.Service
{
    public class CredentialsService : ICredentialsService
    {
        private DBCredentials _credentials = new DBCredentials();

        public DBCredentials GetCredentials()
        {
            return this._credentials;
        }

        public void UpdateCredentials(DBCredentials credentials)
        {
            this._credentials = credentials;
        }
    }
}
