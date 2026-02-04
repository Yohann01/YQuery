using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YQuery.Domain.Model
{
    public interface IInfraMainDatabase
    {
        IInfranstructureApplicationInfo InfranstructureApplicationInfo { get; }
    }
}
