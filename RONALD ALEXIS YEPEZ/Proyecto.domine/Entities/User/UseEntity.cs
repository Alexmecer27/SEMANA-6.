using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.domain.Entities.User
{
    public class UseEntity
    {

    public int UserId { get; set; }
       public string FirstName { get; set; }
        public string LastName { get; set; }

        public int UserCount { get; set; }
        public string Password { get; set; }
    }
}
