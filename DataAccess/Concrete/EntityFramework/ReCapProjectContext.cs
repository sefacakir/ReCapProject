using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //Context: Db tabloları ile roje classlarını bağlamak
    public class ReCapProjectContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //@ \ ters slaşı anlamı dışında kullanır. yani alt satıra geçmek için kullanmaz.
            //connection true= kullanıcı adı şifre gerekmeden giriş yapmamızı sağlıyor.
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ReCapProjectDatabase;Trusted_Connection=true");
        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors{ get; set; }
    }
}
