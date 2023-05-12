using Furion.DatabaseAccessor;

namespace Configgo.Model
{
    public class VHost : Entity<long>
    {

        public string Name { get; set; }

        public string? Description { get; set; }

    }

    public class App : Entity<long>
    {

        public string Name { get; set; }

        public string? Description { get; set; }

        public long VHostId { get; set; }
    }

    public class Env : Entity<long>
    {
        public string Name { get; set; }

        public string Code { get; set; }
    }

    public class Group : Entity<long>
    {
        public string Name { get; set; }

        public string? Description { get; set; }

        public string Key { get; set; }

        public long VHostId { get; set; }
    }

    public class Config : Entity<long>
    {
        public string Key { get; set; }

        public string Val { get; set; }

        public long VHostId { get; set; }

        public long GroupId { get; set; }
    }
}