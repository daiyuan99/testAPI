using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace testAPI.DAL
{
    public class CoreDbContextFactory: IDesignTimeDbContextFactory<CoreDbContext>
    {
        public CoreDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<CoreDbContext>();
            optionsBuilder.UseSqlServer("Server=(local)\\DB2014; Database=TestAPI;Integrated Security=True;MultipleActiveResultSets=true");

            return new CoreDbContext(optionsBuilder.Options);
        }
    }
}
