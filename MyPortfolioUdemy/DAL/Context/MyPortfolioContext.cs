using Microsoft.EntityFrameworkCore;

namespace MyPortfolioUdemy.DAL.Context
{
    public class MyPortfolioContext: DbContext //Db context sınıfına ait sınıflar var onları kullanabilirsin overide= mevcuttak metdou benim istediğim gibi kulllan
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=GOKAY\\SQLEXPRESS;initial Catalog=MyPortfolioDb;integrated Security=true;");
        }

        public DbSet<Entities.SocialMedia> SocialMedias { get; set; }
        public DbSet<Entities.About> Abouts { get; set; }
        public DbSet<Entities.Skill> Skills { get; set; }
        public DbSet<Entities.Experience> Experiences { get; set; }
        public DbSet<Entities.Portfolio> Portfolios { get; set; }
        public DbSet<Entities.Message> Messages { get; set; }
        public DbSet<Entities.Contact> Contacts { get; set; }
        public DbSet<Entities.Testimonial> Testimonials { get; set; }
        public DbSet<Entities.Feature> Features{ get; set; }
        public DbSet<Entities.ToDoList> ToDoLists { get; set; }
    }
}
