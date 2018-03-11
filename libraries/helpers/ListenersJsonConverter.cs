using System;
using System.Linq;
using SuperSocket.SocketBase;
using Newtonsoft.Json;

namespace Libraries.helpers.json
{

    public class ListenersJsonConverterHelper : JsonConverter
    {

        private static Type m_ListenersType = typeof(ListenerInfo[]);

        public override bool CanConvert(Type objectType)
        {

            return objectType == m_ListenersType;

        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {

            return null;

        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {

            if (value == null)
            {

                return;

            }                

            writer.WriteValue(string.Join(", ", ((ListenerInfo[])value).Select(l => l.EndPoint.ToString()).ToArray()));

        }

    }

}
