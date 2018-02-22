using System.Xml.Serialization;
using System.ComponentModel;


namespace Libraries.database.models.character
{

    /// <summary>
    /// Character client unitstate model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "clientState")]
    public class ModelCharacterUnitStateClient : ModelBase
    {

        public ModelCharacterUnitStateClient()
        {

            Actions = new ModelCharacterUnitStateClientActions();
            Tasks = new ModelCharacterUnitStateClientTasks();

        }        

        [XmlAttribute(AttributeName = "unitname")]
        public string Unitname { get; set; }

        [XmlAttribute(AttributeName = "protounit")]
        [DefaultValue(null)]
        public string Protounit { get; set; }

        [XmlAttribute(AttributeName = "position")]
        [DefaultValue(null)]
        public string Position { get; set; }

        [XmlAttribute(AttributeName = "rotation")]
        [DefaultValue(null)]
        public string Rotation { get; set; }

        [XmlAttribute(AttributeName = "variation")]
        public int Variation { get; set; }

        [XmlAttribute(AttributeName = "buildPoints")]
        [DefaultValue(null)]
        public double BuildPoints { get; set; }

        [XmlElement(ElementName = "tasks")]
        [DefaultValue(null)]
        public ModelCharacterUnitStateClientTasks Tasks { get; set; }

        [XmlElement(ElementName = "actions")]
        [DefaultValue(null)]
        public ModelCharacterUnitStateClientActions Actions { get; set; }

    }

}
