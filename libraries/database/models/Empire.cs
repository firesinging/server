using System.Xml.Serialization;

using Libraries.database.models.empire;


namespace Libraries.database.models
{
    
    /// <summary>
    /// Empire model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "Empire")]
    public class ModelEmpire
    {

        [XmlAttribute(AttributeName = "Version")]
        public int Version { get; set; } = 1;

        [XmlAttribute(AttributeName = "Id")]
        public long Id { get; set; }

        [XmlElement(ElementName = "Empire")]
        public ModelEmpireEmpire Empire { get; set; }

        [XmlElement(ElementName = "GameCurrencys")]
        public ModelEmpireGamecurrencys Gamecurrencys { get; set; }

        [XmlElement(ElementName = "Settings")]
        public ModelEmpireSettings Settings { get; set; }

        [XmlElement(ElementName = "MailMessages")]
        public ModelEmpireMailmessages Mailmessages { get; set; }

        [XmlElement(ElementName = "EmpireVault")]
        public ModelEmpireVault Vault { get; set; }

    }

}
