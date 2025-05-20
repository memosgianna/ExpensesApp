using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace FinanceApp.Data
{
    public class FinanceAppContextFactory : IDesignTimeDbContextFactory<FinanceAppContext>
    {
        public FinanceAppContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<FinanceAppContext>();
            optionsBuilder.UseMySql(
                "server=localhost;port=3306;database=mhtsos;user=root;password=memosgianna2002;",
                ServerVersion.AutoDetect("server=localhost;port=3306;database=mhtsos;user=root;password=memosgianna2002;")
            );

            return new FinanceAppContext(optionsBuilder.Options);
        }
    }
}

