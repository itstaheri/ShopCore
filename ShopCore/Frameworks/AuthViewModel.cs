using System.Collections.Generic;

namespace Frameworks
{
    public class AuthViewModel
    {
        public long Id { get; set; }
        public long RoleId { get; set; }
        public string FullName { get; set; }
        public string Username { get; set; }
        public string Number { get; set; }
        public string Email { get; set; }
        public string Picture { get; set; }
        public List<int> Permissions { get; set; }
    }
}