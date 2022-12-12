//using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.ComponentModel;
using System.Text.Json;

namespace WinFormsApp1
{
    class SHelper
    {
        internal static void FileSerialize(SList dormitory, string path)
        {
            var json = JsonSerializer.Serialize(dormitory, new JsonSerializerOptions
            {
                WriteIndented = true
            });
            File.WriteAllText(path, json);
        }

        public static IList<Software> LinqSort(string path, string text1, string text2, string text3)
        {
            string josnFile = File.ReadAllText(path);

            JObject json = JObject.Parse(josnFile);
            var result = json["softwarelisting"]
            .Where(s => s["name"]?.ToString() == text1 || s["annotation"]?.ToString() == text2
            || s["type"].ToString() == text3)
                .Select(s => new Software
                {
                    name = s["name"].ToString(),
                    annotation = s["annotation"].ToString(),
                    type = s["type"].ToString(),
                    version = s["version"].ToString(),
                    author = s["author"].ToString(),
                    usage = s["usage"].ToString(),
                    distribution = s["distribution"].ToString()
                }).ToList();
            return result;
        }
    }
}