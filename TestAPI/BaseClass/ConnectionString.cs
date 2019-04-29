using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAPI.BaseClass
{
    public class ConnectionString
    {
        public static string GetLDS()
        {
            return @"Data Source=192.168.144.15;Initial Catalog=LDS2;User=sa;Pwd=Server12346789!;Pooling=False;Connection Timeout=80";
        }
    }
}
