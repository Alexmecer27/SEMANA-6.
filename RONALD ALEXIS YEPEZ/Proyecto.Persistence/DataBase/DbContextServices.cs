using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.domain.Entities.User;
using Proyecto.Persistence.Configuration;
using Microsoft.EntityFrameworkCore;
using Proyecto.domain.Entities.Customer;
using Proyecto.domain.Entities.Booking;

namespace Proyecto.Persistence.DataBase
{
    public class DbContextServices : DbContext
    {
        public DbContextServices(DbContextOption option): base (option){ }

        public DbSet <UserEntity> User {  get; set; }
        public DbSet<CurtomerEntity> Customer { get; set; }

        public DbSet <BookingEntity> Booking {  get; set; }

        public async Task<bool> SaveAnyc()
        {
            return await SaveChangesAsync()>0;
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            EntityConfiguration(modelBuilder);
        }
        private void EntityConfiguration(ModelBuilder modelBuilder)
        {
            new UserConfiguration(modelBuilder.Entity<UserEntity>());
            new CustomerConfiguration(modelBuilder.Entity<CustomerEntity>());
            new BookingConfiguration(modelBuilder.Entity<BookingEntity>());

        }
    }
}
