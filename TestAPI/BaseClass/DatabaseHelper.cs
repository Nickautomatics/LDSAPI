using DevExpress.Data.Async;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAPI.BaseClass
{
    public class DatabaseHelper
    {
        public static IDataLayer GetDataLayer(string connectionstring)
        {
            XpoDefault.Session = null;
            XpoDefault.ConnectionString = null;
            DevExpress.Xpo.Metadata.XPDictionary dictio = new DevExpress.Xpo.Metadata.ReflectionDictionary();
            dictio.GetDataStoreSchema(typeof(Command).Assembly);
            IDataStore dbstore = XpoDefault.GetConnectionProvider(connectionstring, AutoCreateOption.None);
            ICachedDataStore mainDataStore = new DataCacheRoot(dbstore);
            IDataLayer dl = new SimpleDataLayer(dictio, mainDataStore);
            return dl;
        }

        public static IDataLayer GetLDSDataLayer()
        {
            return GetDataLayer(ConnectionString.GetLDS());
        }
    }
}
