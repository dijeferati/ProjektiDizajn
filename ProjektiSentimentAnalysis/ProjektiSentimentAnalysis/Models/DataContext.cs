﻿
//using ASP.NETCoreIdentityCustom.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using Sentiment_Analysis_Project.Areas.Identity;
//using SentimentAnalysis_Project.Areas.Identity.Data;

namespace Sentiment_Analysis_Project.Models
{
    public class DataContext : DbContext//IdentityDbContext<IdentityUser> //ApplicationUser
    {
        public DataContext(DbContextOptions<DataContext> options)
                : base(options)
        { }

        public DbSet<Instituti> Institutis { get; set; }
        public DbSet<Fakulteti> Fakultetis { get; set; }
        public DbSet<Feedback> Feedbakcs { get; set; }
        public DbSet<Infk> Infks { get; set; }



        /*protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

            builder.ApplyConfiguration(new ApplicationUserEntityConfiguration());
        }
    }

    public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.Property(u => u.Emri).HasMaxLength(255);
            builder.Property(u => u.Mbiemri).HasMaxLength(255);
        }
    }
*/
        //  public class DataContext
        //  {}
    }
}
