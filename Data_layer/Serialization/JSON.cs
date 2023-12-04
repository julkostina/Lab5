using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Data_layer.Serialization
{
    public class JSON<T>
    {
        public static T Read(string FilePath)
        {
            using(FileStream fileStream = new FileStream(FilePath + ".json", FileMode.Open))
            {
                DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(T));
                return (T)jsonSerializer.ReadObject(fileStream);
            }
        }
        public void Write(string file, T[] data)
        {
            using (FileStream fileStream = new FileStream(file + ".json", FileMode.OpenOrCreate))
            {
                DataContractJsonSerializer dataContractJsonSerializer = new DataContractJsonSerializer(typeof(T[]));
                dataContractJsonSerializer.WriteObject(fileStream, data);
            }
        }
    }
}
