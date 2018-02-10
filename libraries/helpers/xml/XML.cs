using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

using Libraries.utf8stringwriter;


namespace Libraries.helpers.xml
{

    /// <summary>
    /// XMLHelper class is a helper for XML related tasks.
    /// </summary>
    public static class XMLHelper
    {

        /// <summary>
        /// Serializes the object.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj">Object to serialize.</param>
        /// <seealso cref="https://stackoverflow.com/questions/1081325/c-sharp-how-to-xml-deserialize-object-itself"/>
        public static string SerializeObjectToXml<T>(this T obj)
        {

            if (obj == null)
            {

                return string.Empty;

            }
            
            XmlSerializer XmlSerializer = new XmlSerializer(obj.GetType());
            XmlWriterSettings Settings = new XmlWriterSettings();
                
            Settings.Encoding = Encoding.UTF8;
            Settings.Indent = true;
            Settings.IndentChars = ("\t");
            Settings.OmitXmlDeclaration = true;
            Settings.NewLineHandling = NewLineHandling.None;

            XmlSerializerNamespaces XmlSerializerNs = new XmlSerializerNamespaces();

            XmlSerializerNs.Add(string.Empty, string.Empty);

            using (Utf8StringWriter Utf8Writer = new Utf8StringWriter())
            {

                using (XmlWriter Writer = XmlWriter.Create(Utf8Writer, Settings))
                {

                    XmlSerializer.Serialize(Writer, obj, XmlSerializerNs);

                }

                return Utf8Writer.ToString();

            }

        }

        /// <summary>
        /// Serializes the object.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj">Object to serialize.</param>
        /// <param name="path">The path.</param>
        /// <seealso cref="https://msdn.microsoft.com/en-us/library/ms143376(v=vs.110).aspx"/>
        /// <seealso cref="https://stackoverflow.com/questions/1081325/c-sharp-how-to-xml-deserialize-object-itself"/>
        public static void SerializeObjectToFile<T>(this T obj, string path)
        {

            if (!string.IsNullOrWhiteSpace(path))
            {

                string Xml = SerializeObjectToXml(obj);

                if (File.Exists(path))
                {

                    File.Delete(path);

                }

                File.WriteAllText(path, Xml, Encoding.UTF8);

            }          
            
        }

        /// <summary>
        /// Deserializes the specified XML.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="xml">The XML.</param>
        /// <seealso cref="https://stackoverflow.com/questions/1081325/c-sharp-how-to-xml-deserialize-object-itself"/>
        public static T DeserializeFromXml<T>(this T original, string xml)
        {

            XmlSerializer Serializer = new XmlSerializer(typeof(T));

            using (MemoryStream Stream = new MemoryStream(Encoding.UTF8.GetBytes(xml)))
            {

                return (T)Serializer.Deserialize(Stream);

            }

        }

        /// <summary>
        /// Deserializes the specified object.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj">Object to deserialize.</param>
        /// <param name="path">The path.</param>
        /// <seealso cref="https://stackoverflow.com/questions/1081325/c-sharp-how-to-xml-deserialize-object-itself"/>
        public static T DeserializeFromFile<T>(this T obj, string path)
        {

            string xml = string.Empty;

            using (StreamReader sr = new StreamReader(path))
            {

                xml = sr.ReadToEnd();
                
            }

            return DeserializeFromXml<T>(obj, xml);

        }

    }

}