using System;
using System.IO;
using Newtonsoft.Json;

namespace MvcApplication2.Controllers
{
    public interface IFileDb : IDisposable
    {
        T GetTable<T>(string tableName);
        void SaveTable<T>(string tableName, T o);
        void DeleteTable(string tableName);
    }

    public class FileDb : IFileDb
    {
        private readonly string _directoryPath;

        public FileDb(string directoryPath)
        {
            _directoryPath = directoryPath;
        }

        private string GetTablePath(string tableName)
        {
            return Path.Combine(_directoryPath, tableName + ".json");
        }

        public T GetTable<T>(string tableName)
        {
            var tablePath = GetTablePath(tableName);

            if (!File.Exists(tablePath))
            {
                return default(T);
            }

            var contents = File.ReadAllText(tablePath);
            return JsonConvert.DeserializeObject<T>(contents);
        }

        public void SaveTable<T>(string tableName, T o)
        {
            var tablePath = GetTablePath(tableName);
            var contents = JsonConvert.SerializeObject(o, Formatting.Indented);
            File.WriteAllText(tablePath, contents);
        }

        public void DeleteTable(string tableName)
        {
            var tablePath = GetTablePath(tableName);
            File.Delete(tablePath);
        }

        public void Dispose()
        {}
    }
}