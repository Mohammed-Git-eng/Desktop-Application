using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject.Models
{
    public class RoomReservation : DbContext
    {
        public RoomReservation() : base("RoomContext")
        {
        }
       // public DbSet<Rooms> Room { get; set; }
        //public DbSet<Customer> Customers { get; set; }
    }
}
