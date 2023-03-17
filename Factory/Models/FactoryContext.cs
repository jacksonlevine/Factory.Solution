using Microsoft.EntityFrameworkCore;

namespace Factory.Models
{
  public class FactoryContext : DbContext
  {
    // public DbSet<Specialty> Specialties { get; set; }
    // public DbSet<Doctor> Doctors { get; set; }
    // public DbSet<Patient> Patients { get; set; }
    // public DbSet<DoctorPatient> DoctorPatients { get; set; }
    // public DbSet<DoctorSpecialty> DoctorSpecialties { get; set; }
    public FactoryContext(DbContextOptions options) : base(options) { }
  }
}