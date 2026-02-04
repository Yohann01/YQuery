using YQuery.Domain.Model;


namespace YQuery.Domain
{
    public class BaseInfrastructurenfo
    {
        public Boolean isValid;
        public List<IInfraAccess> infraAccess { get; set; }
        public IInfrastructureAccessFactory infraFactory { get; set; }

        public IInfraMainDatabase infraMainDatabase;
        public BaseInfrastructurenfo(List<IInfraAccess> pInfraAccess)
        {
            this.infraAccess = pInfraAccess;
            this.infraFactory = new InfrastructureAccessFactory(this.infraAccess);
            this.infraMainDatabase = this.infraFactory.GetInfrastructures<IInfraMainDatabase>();

        }
        public BaseInfrastructurenfo() { }
    }
}
