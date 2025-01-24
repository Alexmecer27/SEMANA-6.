using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proyecto.domain.Entities.Booking;
using Proyecto.domain.Entities.Customer;
using Proyecto.domain.Entities.User;




namespace Proyecto.aplication.Interfaces
{
    public class IDbContextServices
    {
        DbSet<UseEntity> User {  get; set; }

        DbSet <CustomerEntity> Customer { get; set; }   

        DbSet<BookingEntity> Booking { get; set; }

        Task<bool> SaveAnync();

    }
}
