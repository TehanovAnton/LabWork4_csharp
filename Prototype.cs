using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace LabWork2_elementyUprvlenia
{
    public abstract class Prototype<T>
    {
        // глубокое копирование
        public T DeepCopy()
        {
            using (var stream = new MemoryStream())
            {
                var formater = JsonConvert.SerializeObject(this);
                return JsonConvert.DeserializeObject<T>(formater);
            }
        }
    }
}
