using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Database_client.Entities
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string DPI { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
