using Furion.DatabaseAccessor;

namespace Configgo.Model
{
    public class User : Entity<long>
    {
        public string Name { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }

        public string Account { get; set; }

        public string? Salt { get; set; }

        public string Mobile { get; set; }
    }

    public class Role : Entity<long>
    {
        public string Name { get; set; }
    }

    public class UserRole : Entity<long>
    {
        public long UserId { get; set; }

        public long RoleId { get; set; }
    }

    public class RoleVHost : Entity<long>
    {
        public long RoleId { get; set; }

        public long VHostId { get; set; }
    }

    public class RoleApp : Entity<long>
    {
        public long RoleId { get; set; }

        public long AppId { get; set; }

        public long EnvId { get; set; }
    }

}