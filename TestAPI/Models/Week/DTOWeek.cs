using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAPI.Models.Week
{
    public class DTOWeek
    {
        public LDS.Module.PublicEnums.Week Week { get; set; }
        public bool ActiveWeek { get; set; }
        public LDS.Module.PublicEnums.Program Program { get; set; }
        public int Oid { get; set; }

    }
}
