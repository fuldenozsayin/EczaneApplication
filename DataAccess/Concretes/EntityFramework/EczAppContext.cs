using Core.Entities.Concrete;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework
{

    //Context: DB tabloları ile proje classlarını bağlamak
    //Context yapısı veritabanıyla kodumuzdaki nesnemizle ilişkiyi kurduğujmuz class

    //veritabanına bağlantı açmamızı sağlayan classtır.
    //ismindeki "NorthwindContext" contexten etkilenmez. Bunun base sınıfını yani DbContext (entity framework classıdır) implement ederek context sınıfı olduğunu belirtiriz.
    public class EczAppContext:DbContext
    {
        //Bu metot: Projenin hangi veritabanıyla ilişkili olduğunu belirttiğin yer.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //@ işareti ters slaşı kullanabilmek için
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=EczAppDataBase;Trusted_Connection=true"); //SQL server kullanacağımızı söyledik böylece
        }

        //Hangi nesnem hangi tabloma karşılık gelecek?
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<Receipt> Receipts { get; set; }
        public DbSet<ReceiptDetail> ReceiptDetails { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Courier> Couriers { get; set; }
        public DbSet<Seller> Sellers { get; set; }

    }
}
