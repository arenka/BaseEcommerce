using BaseEcommerce.Entitites.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseEcommerce.Data.Concrete
{
    public class BaseEcommerceDbContext : IdentityDbContext
    {
        public BaseEcommerceDbContext()
        {

        }
        public BaseEcommerceDbContext(DbContextOptions<BaseEcommerceDbContext> options)
         : base(options)
        {
        }

        public DbSet<Product>? Product { get; set; }
        public DbSet<Address>? Adress { get; set; }
        public DbSet<Comment>? Comment { get; set; }
        public DbSet<Attachment>? Attachment { get; set; }
        public DbSet<Order> Order { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BaseEcommerceDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            const string USER_ID = "a18be9c0-aa65-4af8-bd17-00bd9344e575";
            const string ADMIN_ID = "ad376a8f-9eab-4bb9-9fca-30b01540f445";
            const string SYSADMIN_ID = "ad376a8f-9eab-4bb9-9fca-30b01540f124";
            const string CUSTOMER_ID = "ad376a8f-9eab-4bb9-9fca-30b01540f985";
            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = ADMIN_ID,
                Name = "Admin",
                NormalizedName = "Admin"
            });
            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = SYSADMIN_ID,
                Name = "SysAdmin",
                NormalizedName = "SysAdmin"
            }); builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = CUSTOMER_ID,
                Name = "Customer",
                NormalizedName = "Customer"
            });
            var hasher = new PasswordHasher<IdentityUser>();
            builder.Entity<IdentityUser>().HasData(new IdentityUser()
            {
                Id = USER_ID,
                UserName = "Email@email.com",
                NormalizedUserName = "email@email.com",
                Email = "Email@email.com",
                NormalizedEmail = "email@email.com",
                EmailConfirmed = false,
                LockoutEnabled = false,
                PasswordHash = hasher.HashPassword(null, "Email123#"),
                SecurityStamp = Guid.NewGuid().ToString(),
                
            });

          
          
            builder.Entity<Product>().HasData(new Product
            {
                Id = 1,
                CreDateTime = DateTime.Now,
                Name = "Moonster Notebook",
                Size = "17 inç",
                Color = "Black",
                Discount = 0,
                Price = 25000,
            });
            builder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                CreDateTime = DateTime.Now,
                Name = "Moonster Notebook",
                Size = "17 inç",
                Color = "Beyaz",
                Discount = 20,
                Price = 25000 
            });
            builder.Entity<Attachment>().HasData(new Attachment
            {
                Id = 1,
                CreDateTime = DateTime.Now,
                ProductId = 1,
                AttachmentUrl = ""
            });
            builder.Entity<Comment>().HasData(new Comment
            {
                Id = 1,
                CreDateTime = DateTime.Now,
                ProductId = 1,
                Descrpition = "Güzel",
                UserId = USER_ID
            });
            builder.Entity<Address>().HasData(new Address
            {
                Id = 1,
                City = "İstanbul",
                CreDateTime = DateTime.Now,
                Description = "",
                State = "Fatih",
                UserId = USER_ID
            });
        }
    }
}
