using YQuery.Domain.Model;

namespace YQuery.Domain
{
    public interface IInfrastructureAccessFactory
    {
        List<IInfraAccess> InfraAccess { get; set; }

        T GetInfrastructures<T>();
    }
}