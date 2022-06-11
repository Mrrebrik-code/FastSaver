using Newtonsoft.Json;
using System;
using System.IO;

namespace Itibsoft.FastSaver
{
    public class JSONHandler
    {
        private string _path;

        public static JSONHandler Create(string path)
        {
            return new JSONHandler(path);
        }

        private JSONHandler(string path)
        {
            _path = path;
            Console.WriteLine("Create JSONHandler object");
        }
      
        public void WriteToJsonFile<T>(string nameFile, T objectToWrite, bool append = false) where T : new()
        {
            TextWriter writer = null;
            try
            {
                var contentsToWriteToFile = JsonConvert.SerializeObject(objectToWrite);
                var filePath = _path + $"\\{nameFile}.json";
                writer = new StreamWriter(filePath, append);
                writer.Write(contentsToWriteToFile);
            }
            finally
            {
                if (writer != null) writer.Close();
            }
        }

        public T ReadFromJsonFile<T>(string nameFile) where T : new()
        {
            TextReader reader = null;
            try
            {
                var filePath = _path + $"\\{nameFile}.json";
                reader = new StreamReader(filePath);
                var fileContents = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<T>(fileContents);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }

        public bool ExistFileName(string nameFile)
		{
            var filePath = _path + $"\\{nameFile}.json";

            return File.Exists(filePath);
		}
    }
}
