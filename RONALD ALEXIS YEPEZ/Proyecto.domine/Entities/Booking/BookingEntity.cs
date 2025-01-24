using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.domain.Entities.Booking
{
    public class BookingEntity
    {

        public int BoookingId { get; set; }
        public DateTime RegisterData { get; set; }

        public string code { get; set; }

        public string Type { get; set; }

        public int CustomerId { get; set; }

        public int UserID { get; set; }
    }
}
