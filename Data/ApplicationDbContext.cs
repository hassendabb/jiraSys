using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Last.Models;
using Microsoft.AspNetCore.Identity;

namespace Last.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<Last.Models.Project> Project { get; set; } = default!;

    // protected override void OnModelCreating(ModelBuilder modelBuilder)
    // {
    //     modelBuilder.Entity<Project>()
    //         .HasOne(p => p.User)
    //         .WithOne(u => u.Project)
    //         .HasForeignKey<User>(u => u.ProjectId); // Specify the foreign key property


    //     // Other configuration code...

    //     base.OnModelCreating(modelBuilder);
    // }

    public DbSet<Last.Models.Ticket> Ticket { get; set; } = default!;
}
