using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YQuery.Shared.Model;

namespace YQuery.Service
{
    public class DBContextFactory
    {
        private readonly UserSession _userSession;
        //public DbContextFactory(UserSession userSession)
        //{
        //    _userSession = userSession; // singleton
        //}

        //public ToolingDbContext Create()
        //{
        //    var connString = $"Server={_userSession.ServerName};User Id={_userSession.UserId};Password={_userSession.Password};TrustServerCertificate=True;";
        //    var options = new DbContextOptionsBuilder<ToolingDbContext>()
        //    .Options;

        //    return new ToolingDbContext(options);
        //}
    }
}
