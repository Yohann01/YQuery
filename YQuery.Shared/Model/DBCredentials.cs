using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YQuery.Shared.Model
{
    public class DBCredentials
    {
        public string? SeverName { get; set; }
        public string? DatabaseName { get; set; } = "DellwoodBE";
        public string? UserId { get; set; }
        public string? Password { get; set; }
    }
}
