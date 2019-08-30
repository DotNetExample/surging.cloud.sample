using Surging.Core.Domain.Entities;

namespace Surging.Sample.Domain.User
{
    public class UserInfo : Entity<long>
    {
        public string Code { get; set; }

        public string Name { get; set; }
    }
}
