using Microsoft.EntityFrameworkCore;

namespace Todo_App.Models {
    public class MainDbContext : DbContext {
        public DbSet<List> Lists { get; set; }
        public DbSet<Task> Tasks { get; set; }

        public MainDbContext() {

        }

        public MainDbContext(DbContextOptions<MainDbContext> options) : base(options) {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {

            modelBuilder.Entity<List>(builder => builder.HasData(
                new List() {
                    Id = 1,
                    Name = "testList"
                }
            ));

            modelBuilder.Entity<Task>(builder => builder.HasData(
                new Task() {
                    Id = 1,
                    ListId = 1,
                    CreatedDate = DateTime.Now,
                    Description = "testTask"
                }
            ));
        }
    }
}
