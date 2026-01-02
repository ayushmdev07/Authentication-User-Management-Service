using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthService.Domain.Entities
{
    internal class User
    {
        public Guid Id { get; set; }
        public string Email { get; set; } = null!;
        public string PassordHash { get; set; } = null!;
        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; }
        public ICollection<Role> Roles { get; set; }    
    }
}
