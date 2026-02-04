using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YQuery.Domain.Model;

namespace YQuery.Domain.Domain.ApplicationInfo
{
    public class BaseApplicationInfo : BaseInfrastructurenfo
    {
        protected IInfranstructureApplicationInfo InfraApplicationInfo { get { return this.infraMainDatabase.InfranstructureApplicationInfo; } }

        public BaseApplicationInfo(List<IInfraAccess> pInfraAccess) :  base(pInfraAccess)
        {
        }
    }
}
