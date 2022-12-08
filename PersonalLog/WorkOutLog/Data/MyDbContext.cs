using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using WorkOutLog.Models;

namespace WorkOutLog.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }

        public DbSet<Log> WorkOuts { get; set; }
    }


    ////This information below was added to resolve the Microsoft.TypeMappingSource Dependecies issue that I was having. There appears to be a bug with the update. 
    //// This site was used https://www.svrz.com/unable-to-resolve-service-for-type-microsoft-entityframeworkcore-storage-typemappingsourcedependencies/
    ////
    //public class MysqlEntityFrameworkDesignTimeServices : IDesignTimeServices
    //{
    //    public void ConfigureDesignTimeServices(IServiceCollection serviceCollection)
    //    {
    //        serviceCollection.AddEntityFrameworkMySQL();
    //        new EntityFrameworkRelationalDesignServicesBuilder(serviceCollection)
    //            .TryAddCoreServices();
    //    }
    //}


}
