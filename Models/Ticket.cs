using System;

namespace Last.Models
{
    public class Ticket
    {
        public int? TicketId { get; set; }
        public string? Title { get; set; }
        public string? Priority { get; set; }
        public Last.Enums.TaskStatus? Status { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? ClosedAt { get; set; }

        public int? UserId { get; set; }
        // public User? User { get; set; }
        public int? ProjectId { get; set; }
        public Project? Project { get; set; }
    }
}



