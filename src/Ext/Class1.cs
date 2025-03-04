using System.Runtime.Serialization.Formatters.Binary;

namespace Ext
{
    public class Class1
    {
        public Class1()
        {
            
        }

        public byte[] Test()
        {
            var bf = new BinaryFormatter();
            using var ms = new MemoryStream();
            bf.Serialize(ms, "test");
            return ms.ToArray();
        }
    }
}
