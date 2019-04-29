using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAPI.Models.User
{
    [NonPersistent]
    public class NPUser : XPLiteObject
    {
        protected NPUser(Session session) : base(session)
        {

        }


        Guid teacher;
        int network;
        int year;
        string iDNumber;
        int batch;
        int program;
        Guid oid;

        public Guid Oid
        {
            get => oid;
            set => SetPropertyValue(nameof(Oid), ref oid, value);
        }

        public int Program
        {
            get => program;
            set => SetPropertyValue(nameof(Program), ref program, value);
        }

        public int Batch
        {
            get => batch;
            set => SetPropertyValue(nameof(Batch), ref batch, value);
        }

        public string IDNumber
        {
            get => iDNumber;
            set => SetPropertyValue(nameof(IDNumber), ref iDNumber, value);
        }

        public int Year
        {
            get => year;
            set => SetPropertyValue(nameof(Year), ref year, value);
        }

        public int Network
        {
            get => network;
            set => SetPropertyValue(nameof(Network), ref network, value);
        }
        
        public Guid Teacher
        {
            get => teacher;
            set => SetPropertyValue(nameof(Teacher), ref teacher, value);
        }

    }
}
