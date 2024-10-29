using JobStation.Core.Domain;
using JobStation.Core.EntityConfiguration;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace JobStation.Core
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
       

        public DbSet<JobCategory> JobCategories { get; set; }
        public DbSet<JobType> JobTypes { get; set; }
        public  DbSet<JobOffer> JobOffers { get; set; }
        public  DbSet<JobLocation> JobLocations { get; set; }
        public  DbSet<JobSeekerProfile> JobSeekerProfiles { get; set; }

        public  DbSet<OrganisationDetails> OrganisationDetails { get; set; }

        public  DbSet<SeekerSkillList> SeekerSkillLists { get; set; }
        public  DbSet<SkillList> SkillLists { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new JobTypeConfiguration());
            modelBuilder.ApplyConfiguration(new JobOfferConfiguration());
            modelBuilder.ApplyConfiguration(new JobCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new JobLocationConfiguration());
            modelBuilder.ApplyConfiguration(new JobSeekerProfileConfiguration());
            modelBuilder.ApplyConfiguration(new OrganisationDetailsConfiguration());
            modelBuilder.ApplyConfiguration(new SeekerSkillListConfiguration());
            modelBuilder.ApplyConfiguration(new SkillListConfiguration());

        }
    }
}
