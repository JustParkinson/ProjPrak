using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Proj22.Models.DataModels;
using System;

namespace Proj22.Entity
{
    public class AppDbContext : IdentityDbContext<User,Role,int>
    {

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseLazyLoadingProxies();
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<User>()
                .ToTable("AspNetUsers")
                .HasDiscriminator<int>("UserType")
                .HasValue<User>((int)RoleValue.User)
                .HasValue<Administrator>((int)RoleValue.Administrator)
                .HasValue<Moderator>((int)RoleValue.Moderator);
            builder.Entity<Post>()
                .HasKey(k => new { k.Id, k.UserID, k.BlogId });

            builder.Entity<Post>()
                .HasOne(b => b.Blog)
                .WithMany(p => p.Posts)
                .HasForeignKey(i => i.BlogId);

            var hasher = new PasswordHasher<Administrator>();
            builder.Entity<Administrator>()
                .HasData(
                new Administrator
                {
                    Id = 1,
                    UserName = "Admin",
                    FirstName = "Łuaksz",
                    LastName = "Nowak",
                    BrithDay = new DateTime(1999, 04, 23),
                    PasswordHash = hasher.HashPassword(null, "admin"),
                    Email = "xd@xd.pl",
                    NormalizedEmail = "xd@xd.pl",
                    EmailConfirmed = true

                });
                

        }
    }
}
