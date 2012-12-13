using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Json;

namespace TechEasy.Core.Helper
{
    public class JsonHelper
    {
        public static string JsonSerialize<T>(T data)
        {
            MemoryStream stream = new MemoryStream();
            JsonSerialize(typeof(T), data, stream);
            return Encoding.Default.GetString(stream.ToArray());
        }

        public static object JsonDeserialize<T>(string json)
        {
            MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(json));
            return JsonDeserialize(typeof(T), stream);
        }

        public static void JsonSerialize(Type type, object data, Stream stream)
        {
            DataContractJsonSerializer ser = new DataContractJsonSerializer(type);

            ser.WriteObject(stream, data);
            stream.Close();
        }

        public static object JsonDeserialize(Type type, Stream stream)
        {
            DataContractJsonSerializer ser = new DataContractJsonSerializer(type);

            var data = ser.ReadObject(stream);
            stream.Close();

            return data;
        }
    }
}

