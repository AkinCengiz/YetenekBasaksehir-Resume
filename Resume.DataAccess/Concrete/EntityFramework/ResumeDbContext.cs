using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Resume.Entity.Concrete;

namespace Resume.DataAccess.Concrete.EntityFramework;
public class ResumeDbContext : DbContext
{
	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseSqlServer(
			"Data Source=ACENGIZ\\AKINCENGIZ;initial catalog=ResumeDb;Integrated Security=True;Trust Server Certificate=True;");
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		//modelBuilder.Entity<Town>().HasOne(a => a.City).WithMany(t => t.Towns).HasForeignKey(a => a.CityId);
		//modelBuilder.Entity<City>().HasMany(t => t.Towns).WithOne(t => t.City).
		base.OnModelCreating(modelBuilder);
	}

	public DbSet<Address> Addresses { get; set; }
	public DbSet<AwardAndCertificate> AwardAndCertificates { get; set; }
	public DbSet<City> Cities { get; set; }
	public DbSet<Contact> Contacts { get; set; }
	public DbSet<Education> Educations { get; set; }
	public DbSet<Experience> Experiences { get; set; }
	public DbSet<Interest> Interests { get; set; }
	public DbSet<Person> Persons { get; set; }
	public DbSet<Skill> Skills { get; set; }
	public DbSet<Town> Towns { get; set; }
	public DbSet<Workflow> Workflows { get; set; }
	public DbSet<SocialAccount> SocialAccounts { get; set; }
}
