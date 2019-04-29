using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAPI.BaseClass
{
    public static class Query
    {
        public static string GetStudents()
        {
            return @"SELECT Oid, Program, Batch, IDNumber, Year, Network, Teacher FROM Student";
        }

        public static string GetTeacher()
        {
            return @"SELECT Oid, FirstName, LastName, UserName, [Password] FROM AssistantTeacher where GCRecord is null";
        }
    }
}
