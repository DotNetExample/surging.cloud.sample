using System.Threading.Tasks;
using Surging.Core.ProxyGenerator;
using Surging.Sample.Domain.User;
using Surging.Sample.IApplication.User;
using Surging.Sample.IApplication.User.Dtos;

namespace Surging.Sample.Application.User
{
    public class UserAppService : ProxyServiceBase, IUserAppService
    {
        private readonly IUserDomanService _userDomanService;

        public UserAppService(IUserDomanService userDomanService) {
            _userDomanService = userDomanService;
        }

        public async Task<string> CreateUser(CreateUserInput createUserInput)
        {
            await _userDomanService.CreateUser(createUserInput);
            return "新增用户成功";
        }
    }
}
