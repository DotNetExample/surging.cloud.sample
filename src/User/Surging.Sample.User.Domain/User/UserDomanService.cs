using System.Threading.Tasks;
using Surging.Core.Dapper.Repositories;
using Surging.Sample.IApplication.User.Dtos;

namespace Surging.Sample.Domain.User
{
    public class UserDomanService : IUserDomanService
    {

        private readonly IDapperRepository<UserInfo, long> _userInfoRepository;
        public UserDomanService(IDapperRepository<UserInfo, long> userInfoRepository) {
            _userInfoRepository = userInfoRepository;
        }

        public async Task CreateUser(CreateUserInput input)
        {
            await _userInfoRepository.InsertAsync(new UserInfo() {
                Code = input.Code,
                Name = input.Name
            }); 
        }
    }
}
