using Surging.Core.CPlatform.Ioc;
using Surging.Core.CPlatform.Runtime.Server.Implementation.ServiceDiscovery.Attributes;
using Surging.Sample.IApplication.User.Dtos;
using System.Threading.Tasks;

namespace Surging.Sample.IApplication.User
{
    [ServiceBundle("v1/api/{AppService}/{Method}")]
    public interface IUserAppService : IServiceKey
    {
 
        Task<string> CreateUser(CreateUserInput createUserInput);
    }
}
