using YQuery.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YQuery.Domain
{
    public class InfrastructureAccessFactory : IInfrastructureAccessFactory
    {
        public List<IInfraAccess> InfraAccess { get; set; }


        public InfrastructureAccessFactory(List<IInfraAccess> pDataAccess)
        {
            this.InfraAccess = pDataAccess;
        }

        public T GetInfrastructures<T>()
        {
            T Value = default(T);

            try
            {
                foreach (IInfraAccess DL in this.InfraAccess)
                {
                    Type tDL = DL.GetType();
                    Type[] ArrInterfaces = tDL.GetInterfaces();

                    foreach (Type iT in ArrInterfaces)
                    {
                        if (iT.Name == typeof(T).Name)
                        {
                            Value = (T)DL;
                            break;
                        }
                    }

                    if (Value != null)
                    {
                        break;
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return (T)Value;
        }
    }
}
