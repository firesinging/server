using System.Xml.Serialization;
using System.ComponentModel;


namespace Libraries.database.models.character
{

    /// <summary>
    /// Character client unitstate action model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "action")]
    public class ModelCharacterUnitStateClientAction
    {

        [XmlAttribute(AttributeName = "trainpoints")]
        public double Trainpoints { get; set; }

        [XmlAttribute(AttributeName = "actiontype")]
        public int Actiontype { get; set; }

        [XmlAttribute(AttributeName = "actionname")]
        public string Actionname { get; set; }

        [XmlElement(ElementName = "productionitems")]
        [DefaultValue(null)]
        public ModelCharacterUnitStateClientActionProductionItems ProductionItems { get; set; }

    }

}
