using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using AlterSpamTool.Model;

namespace AlterSpamTool.DataAccess
{
    public class AlterSpamToolDbContext : DbContext
    {
        public AlterSpamToolDbContext():base("AlterSpamToolDb")
        {
            
        }

        public DbSet<Sender> Senders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
