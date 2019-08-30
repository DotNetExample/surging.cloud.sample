using Surging.Core.CPlatform.Ioc;
using Surging.Sample.IApplication.User.Dtos;
using System.Threading.Tasks;

namespace Surging.Sample.Domain.User
{
    public interface IUserDomanService : ITransientDependency
    {
        Task CreateUser(CreateUserInput input);
    }
}
