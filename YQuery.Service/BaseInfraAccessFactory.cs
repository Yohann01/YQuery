using YQuery.Domain.Model;

namespace YQuery.Service
{
    public abstract class BaseInfraAccessFactory
    {
        private readonly IRegisterInfraAccess _registerInfraAccess;
        private readonly List<IInfraAccess> _infraAccess;
        public List<IInfraAccess> infraAccesses { get { return this._infraAccess; } }

        public BaseInfraAccessFactory(IRegisterInfraAccess registerDataAccess)
        {
            this._registerInfraAccess = registerDataAccess;
            this._infraAccess = this._registerInfraAccess.GetAllInfraAccesses();
        }
    }
}
