using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAPI.Models.Teacher
{
    [NonPersistent]
    public class NPTeacher : XPLiteObject
    {

        string password;
        string userName;
        string lastName;
        string firstName;
        Guid oid;

        protected NPTeacher(Session session) : base(session)
        {

        }

        public Guid Oid
        {
            get => oid;
            set => SetPropertyValue(nameof(Oid), ref oid, value);
        }


        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string FirstName
        {
            get => firstName;
            set => SetPropertyValue(nameof(FirstName), ref firstName, value);
        }


        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string LastName
        {
            get => lastName;
            set => SetPropertyValue(nameof(LastName), ref lastName, value);
        }


        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string UserName
        {
            get => userName;
            set => SetPropertyValue(nameof(UserName), ref userName, value);
        }

        
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Password
        {
            get => password;
            set => SetPropertyValue(nameof(Password), ref password, value);
        }
    }
}
