using System;
using System.Collections;
using System.Runtime.Remoting;

namespace Common
{
    /* Mechanism for instanciating a remote object through its interface, using the config file */

    public class RemoteNew
    {
        private static Hashtable types = null;

        private static void InitTypeTable()
        {
            types = new Hashtable();
            WellKnownClientTypeEntry[] ar = RemotingConfiguration.GetRegisteredWellKnownClientTypes();

            foreach (WellKnownClientTypeEntry entry in ar)
            {
                //Type tp = Type.GetType(entry.TypeName);
                types.Add(entry.ObjectType, entry);
            }
        }

        public static object New(Type type)
        {
            if (types == null)
                InitTypeTable();
            WellKnownClientTypeEntry entry = (WellKnownClientTypeEntry)types[type];
            if (entry == null)
                throw new RemotingException("Type not found!");
            return RemotingServices.Connect(type, entry.ObjectUrl);
        }
    }
}
