using System.Xml.Serialization;


namespace Libraries.database.models.civilization
{

    /// <summary>
    /// Civilization matchmaking textures model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "matchmakingtextures")]
    public class ModelCivilizationMatchmakingtextures
    {

        [XmlElement(ElementName = "bannertexture")]
        public string Bannertexture { get; set; }

        [XmlElement(ElementName = "bannertexturecoords")]
        public string Bannertexturecoords { get; set; }

        [XmlElement(ElementName = "portraittexture")]
        public string Portraittexture { get; set; }

        [XmlElement(ElementName = "portraittexturecoords")]
        public string Portraittexturecoords { get; set; }

        [XmlElement(ElementName = "smallportraittexture")]
        public string Smallportraittexture { get; set; }

        [XmlElement(ElementName = "smallportraittexturecoords")]
        public string Smallportraittexturecoords { get; set; }

    }

}
