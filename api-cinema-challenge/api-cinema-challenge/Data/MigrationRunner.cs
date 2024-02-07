using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace api_cinema_challenge.Data
{
  public static class MigrationRunner
  {
    public static void ApplyProjectMigrations(this WebApplication app)
    {
      // create a scope to be able to create/get a service
      using (var scope = app.Services.CreateScope())
      {
        // retrieve the db context service 
        var db = scope.ServiceProvider.GetRequiredService<CinemaContext>();
        // run migrations if not run (+ seeding)
        db.Database.Migrate();
      }
    }
  }
}