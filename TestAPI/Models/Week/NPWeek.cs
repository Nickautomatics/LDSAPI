using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAPI.Models.Week
{
    [NonPersistent]
    public class NPWeek : XPLiteObject
    {
        protected NPWeek(Session session) : base(session)
        {

        }

        int program;
        bool activeWeek;
        int weeks;
        int oid;

        public int Oid
        {
            get => oid;
            set => SetPropertyValue(nameof(Oid), ref oid, value);
        }

        public int Weeks
        {
            get => weeks;
            set => SetPropertyValue(nameof(Weeks), ref weeks, value);
        }

        public bool ActiveWeek
        {
            get => activeWeek;
            set => SetPropertyValue(nameof(ActiveWeek), ref activeWeek, value);
        }

        public int Program
        {
            get => program;
            set => SetPropertyValue(nameof(Program), ref program, value);
        }
    }
}
