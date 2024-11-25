using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CareerPathCore.Domain.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
    }
}