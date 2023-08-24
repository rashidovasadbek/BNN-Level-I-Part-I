using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace Department.fileManager
{
    public class FileService<T>
    {
        private List<T> Values = new List<T>();
        public static string path = "";

        public void Add(List<T> values)
        {
            var fileData = JsonSerializer.Deserialize<List<T>>(File.ReadAllText(path));
            Values.AddRange(fileData);
            string jsonResult = JsonSerializer.Serialize(Values);
            File.WriteAllText(path, jsonResult);
        }
    }
}
