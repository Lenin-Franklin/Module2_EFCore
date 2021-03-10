using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using HandsOnCodeFirst_Demo1.Entities;
namespace HandsOnCodeFirst_Demo1.DBAccess
{
    class MyContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //configure connection string
            optionsBuilder.UseSqlServer(@"Data Source=SANTU\MSSQLSERVER2019;Initial Catalog=OnlineShoppiDB;Integrated Security=True");
        }
        //configure the entity sets
        public DbSet<Product> Products { get; set; }
    }
}
