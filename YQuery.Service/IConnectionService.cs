using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YQuery.Shared.Model;

namespace YQuery.Service
{
    public interface IConnectionService
    {
        Task<bool> Connect();

        Task<List<string>> GetDatabasesAsync();
    }
}
