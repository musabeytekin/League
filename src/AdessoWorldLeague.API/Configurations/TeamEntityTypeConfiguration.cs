using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdessoWorldLeague.API.Configurations;

public class TeamEntityTypeConfiguration : IEntityTypeConfiguration<Team>
{
    public void Configure(EntityTypeBuilder<Team> builder)
    {
        builder.ToTable("teams");
        
        builder.HasKey(t => t.Id);
        builder.HasData(
            new Team() {Id = 1, Name = "Adesso Istanbul", Country = "Turkiye"},
            new Team() {Id = 2, Name = "Adesso Ankara", Country = "Turkiye"},
            new Team() {Id = 3, Name = "Adesso Izmir", Country = "Turkiye"},
            new Team() {Id = 4, Name = "Adesso Antalya", Country = "Turkiye"},
            
            new Team() {Id = 5, Name = "Adesso Berlin", Country = "Almanya"},
            new Team() {Id = 6, Name = "Adesso Frankfurt", Country = "Almanya"},
            new Team() {Id = 7, Name = "Adesso Munih", Country = "Almanya"},
            new Team() {Id = 8, Name = "Adesso Dortmund", Country = "Almanya"},
            
            new Team() {Id = 9, Name = "Adesso Paris", Country = "Fransa"},
            new Team() {Id = 10, Name = "Adesso Marsilya", Country = "Fransa"},
            new Team() {Id = 11, Name = "Adesso Lyon", Country = "Fransa"},
            new Team() {Id = 12, Name = "Adesso Nice", Country = "Fransa"},
            
            new Team() {Id = 13, Name = "Adesso Amsterdam", Country = "Hollanda"},
            new Team() {Id = 14, Name = "Adesso Rotterdam", Country = "Hollanda"},
            new Team() {Id = 15, Name = "Adesso Lahey", Country = "Hollanda"},
            new Team() {Id = 16, Name = "Adesso Eindhoven", Country = "Hollanda"},
            
            new Team() {Id = 17, Name = "Adesso Lisbon", Country = "Portekiz"},
            new Team() {Id = 18, Name = "Adesso Porto", Country = "Portekiz"},
            new Team() {Id = 19, Name = "Adesso Braga", Country = "Portekiz"},
            new Team() {Id = 20, Name = "Adesso Coimbra", Country = "Portekiz"},
            
            new Team() {Id = 21, Name = "Adesso Roma", Country = "Italya"},
            new Team() {Id = 22, Name = "Adesso Milano", Country = "Italya"},
            new Team() {Id = 23, Name = "Adesso Venedik", Country = "Italya"},
            new Team() {Id = 24, Name = "Adesso Napoli", Country = "Italya"},
            
            new Team() {Id = 25, Name = "Adesso Madrid", Country = "Ispanya"},
            new Team() {Id = 26, Name = "Adesso Barselona", Country = "Ispanya"},
            new Team() {Id = 27, Name = "Adesso Sevilla", Country = "Ispanya"},
            new Team() {Id = 28, Name = "Adesso Granada", Country = "Ispanya"},
            
            new Team() {Id = 29, Name = "Adesso Bruksel", Country = "Belcika"},
            new Team() {Id = 30, Name = "Adesso Brugge", Country = "Belcika"},
            new Team() {Id = 31, Name = "Adesso Gent", Country = "Belcika"},
            new Team() {Id = 32, Name = "Adesso Anvers", Country = "Belcika"}
            
        );
    }
}