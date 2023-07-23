using System.Collections.Generic;
using Last.Enums;
using Microsoft.AspNetCore.Identity;

namespace Last.Models
{
    public class User : IdentityUser
    {
        //     public int? UserId { get; set; }
        //     public string? FullName { get; set; }
        //     public string? Username { get; set; }
        //     public string? Email { get; set; }
        public UserRole? Role { get; set; }

        public List<Ticket>? Tickets { get; set; }
        public Project? Project { get; set; }
        public int ProjectId { get; set; }

        //     public string? ConfirmPassword { get; set; }

    }
}
