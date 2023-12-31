using Microsoft.EntityFrameworkCore;

namespace PandoraCaseTest.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            MyDbContext context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<MyDbContext>();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Users.Any())
            {
                context.Users.AddRange(
                    new User { Login = "olaf", Mail = "olaf@steam.pl", Pass="Maslo123"},
                    new User { Login = "jajdys", Mail = "jajdys@cos.pl", Pass = "321olsaM" },
                    new User { Login = "sienki", Mail = "sienki@interia.pl", Pass = "123Maslo" },
                    new User { Login = "ciufciuf", Mail = "ciufciuf@o2.pl", Pass = "123olsaM" },
                    new User { Login = "plb", Mail = "plb@gmail.com", Pass = "Maslo123456" }
                    );
                context.SaveChanges();
            }
        }
    }
}
