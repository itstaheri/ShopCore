namespace AM.Domain.Role
{
    public class Permission
    {
        public Permission(int code)
        {
            Code = code;
        }

        public Permission(int code, string name) : this(code)
        {
            Name = name;
        }

        public long Id { get;private set; }
        public int Code { get;private set; }
        public string Name { get;private set; }
        public long RoleId { get;private set; }
        public RoleModel role { get;private set; }
    }
}
