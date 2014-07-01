using System.Data.Entity;
using System.Data.Entity.SqlServer;
using System.Data.Entity.Infrastructure.Interception;

namespace ContosoUniversity.DAL
{
    public class SchoolConfiguration : DbConfiguration
    {
        public SchoolConfiguration()
        {
            SetExecutionStrategy("System.Data.SqlClient", () => new SqlAzureExecutionStrategy());


            DbInterception.Add(new SchoolInterceptorLogging());
        }
    }
}