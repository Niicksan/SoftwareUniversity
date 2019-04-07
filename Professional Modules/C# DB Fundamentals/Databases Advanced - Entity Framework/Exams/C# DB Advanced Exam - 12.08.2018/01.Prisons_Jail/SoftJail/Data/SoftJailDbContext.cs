using SoftJail.Data.Models;

namespace SoftJail.Data
{
	using Microsoft.EntityFrameworkCore;

	public class SoftJailDbContext : DbContext
	{
		public SoftJailDbContext()
		{
		}

		public SoftJailDbContext(DbContextOptions options)
			: base(options)
		{
		}

	    public DbSet<Cell> Cells { get; set; }

	    public DbSet<Department> Departments { get; set; }

	    public DbSet<Mail> Mails { get; set; }

	    public DbSet<Officer> Officers { get; set; }

	    public DbSet<OfficerPrisoner> OfficersPrisoners { get; set; }

	    public DbSet<Prisoner> Prisoners { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				optionsBuilder
					.UseSqlServer(Configuration.ConnectionString);
			}
		}

	    //todo on model creating 

        protected override void OnModelCreating(ModelBuilder builder)
		{
		    builder.Entity<OfficerPrisoner>()
		        .HasKey(p => new { p.OfficerId, p.PrisonerId });

		    builder.Entity<OfficerPrisoner>()
		        .HasOne(x => x.Prisoner)
		        .WithMany(x => x.PrisonerOfficers)
		        .OnDelete(DeleteBehavior.Restrict);

		    builder.Entity<OfficerPrisoner>()
		        .HasOne(x => x.Officer)
		        .WithMany(x => x.OfficerPrisoners)
		        .OnDelete(DeleteBehavior.Restrict);

        }
	}
}