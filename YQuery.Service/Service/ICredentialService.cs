using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YQuery.Shared.Model;

namespace YQuery.Service.Service
{
    public interface ICredentialsService
    {
        DBCredentials GetCredentials();
        void UpdateCredentials(DBCredentials credentials);
    }
}
