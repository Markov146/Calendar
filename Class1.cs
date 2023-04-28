using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendary
{
    internal class Class1
    {
        string rootFolder = Path.GetFullPath(@"..\..\..\");

        public void JsonSer<T>(T type)
        {
            string JsonWrite = JsonConvert.SerializeObject(type);
            File.WriteAllText(rootFolder + "\\SaveCal.json", JsonWrite);
        }
        public T JsonDeser<T>()
        {
            string JsonRead = File.ReadAllText(rootFolder + "\\SaveCal.json");
            T Mytype = JsonConvert.DeserializeObject<T>(JsonRead);
            return Mytype;
        }
    }
}
