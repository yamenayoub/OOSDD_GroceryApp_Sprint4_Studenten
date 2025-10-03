
using Grocery.Core.Enums;

namespace Grocery.Core.Models
{
    public partial class Client : Model
    {
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; } = Role.None;
        public Client(int id, string name, string emailAddress, string password, Role role = Role.None) : base(id, name)
        {
            EmailAddress=emailAddress;
            Password=password;
            Role = role;
        }
    }
}
