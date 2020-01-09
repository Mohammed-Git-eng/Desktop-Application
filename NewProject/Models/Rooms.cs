using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject.Models
{
    class Rooms
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Cost { get; set; }

        public double Price { get; internal set; }
    }
}
