namespace DataLayer
{
    using System.Data.Entity;
    using BusinessLayer;

    public class AutoMotiveContext : DbContext
    {
        public AutoMotiveContext() :base("AutoMotiveContext")
        {
            
        }
        public DbSet<Car> Cars { get; set; }
    }
}