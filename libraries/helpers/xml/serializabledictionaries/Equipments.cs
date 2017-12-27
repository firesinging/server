using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;


namespace Libraries.helpers.xml
{

    /// <summary>
    /// Equipments serializable dictionary
    /// </summary>
    /// <seealso cref="https://weblogs.asp.net/pwelter34/444961"/>
    /// 
    [XmlRoot(ElementName = "equipmentdata")]
    public class SerDictionaryEquipments<TKey, TValue> : Dictionary<TKey, TValue>, IXmlSerializable
    {

        public System.Xml.Schema.XmlSchema GetSchema()
        {

            return null;

        }

        public void ReadXml(XmlReader reader)
        {

        }

        public void WriteXml(XmlWriter writer)
        {

            XmlSerializer Serializer = new XmlSerializer(typeof(TValue));
            XmlSerializerNamespaces SerializerNs = new XmlSerializerNamespaces();

            SerializerNs.Add(string.Empty, string.Empty);

            foreach (TKey key in this.Keys)
            {

                TValue value = this[key];
                Serializer.Serialize(writer, value, SerializerNs);

            }

        }

    }

}
