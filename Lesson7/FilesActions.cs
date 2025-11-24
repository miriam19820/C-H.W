using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Xml.Serialization; 

namespace Lesson7
{
   
    public static class JsonHandler
    {
        public static List<Person> Load(string path)
        {
            if (!File.Exists(path)) throw new FileNotFoundException("File not found");
            string json = File.ReadAllText(path);
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            return JsonSerializer.Deserialize<List<Person>>(json, options) ?? new List<Person>();
        }

        public static void Save(string path, List<Person> list)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(list, options);
            File.WriteAllText(path, json);
        }
    }

   
    public static class XmlHandler
    {
        public static List<Person> Load(string path)
        {
            if (!File.Exists(path)) throw new FileNotFoundException("File not found");

            XmlSerializer serializer = new XmlSerializer(typeof(List<Person>));
            using (FileStream stream = new FileStream(path, FileMode.Open))
            {
                return (List<Person>)serializer.Deserialize(stream);
            }
        }

        public static void Save(string path, List<Person> list)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Person>));
            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                serializer.Serialize(stream, list);
            }
        }
    }
}