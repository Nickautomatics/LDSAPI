using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAPI.Models.User
{
    public class DTOUser
    {
        public Guid Teacher { get; set; }
        public int Network { get; set; }
        public int Year { get; set; }
        public string IDNumber { get; set; }
        public int Batch { get; set; }
        public int Program { get; set; }
        public Guid Oid { get; set; }
    }
}
