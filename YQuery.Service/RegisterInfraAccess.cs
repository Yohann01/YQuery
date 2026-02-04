using System.Collections.Generic;
using YQuery.Domain.Model;
using YQuery.Infrastructure;
using YQuery.Service;
using YQuery.Service.Service;
using YQuery.Shared.Model;

namespace YQuery.Service
{
    public sealed class RegisterInfraAccess : IRegisterInfraAccess
    {
        private static IRegisterInfraAccess _instance;
        private readonly List<IInfraAccess> _infraAccess;
        private readonly ICredentialsService _credentialsService;

        private RegisterInfraAccess(ICredentialsService credentialsService)
        {
            this._credentialsService = credentialsService ?? throw new ArgumentNullException(nameof(credentialsService));
            this._infraAccess = this.Register();
        }

        public static IRegisterInfraAccess GetInstance(ICredentialsService credentialsService)
        {
            _instance = new RegisterInfraAccess(credentialsService);
            return _instance;
        }

        private List<IInfraAccess> Register()
        {
            DBCredentials credentials = this._credentialsService.GetCredentials();
            List <IInfraAccess> infraAccess = new()
            {
                new InfraMainDatabase(credentials)
            };

            return infraAccess;
        }

        public List<IInfraAccess> GetAllInfraAccesses()
        {
            return this._infraAccess;
        }
    }
}