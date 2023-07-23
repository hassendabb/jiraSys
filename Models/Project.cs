using System;
using System.Collections.Generic;

namespace Last.Models
{
    public class Project
    {
        public int? ProjectId { get; set; }
        public string? Name { get; set; }

        public List<Ticket>? Tickets { get; set; }
        // public User? User { get; set; }
    }
}