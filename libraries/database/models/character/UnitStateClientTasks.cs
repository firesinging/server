using System.Xml.Serialization;
using System.Collections.Generic;
using System.ComponentModel;


namespace Libraries.database.models.character
{

    /// <summary>
    /// Character client unitstate tasks model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "tasks")]
    public class ModelCharacterUnitStateClientTasks
    {
        
        public ModelCharacterUnitStateClientTasks()
        {

            Items = new List<ModelCharacterUnitStateClientTask>();            

        }

        [XmlElement(ElementName = "task")]
        [DefaultValue(null)]
        public List<ModelCharacterUnitStateClientTask> Items { get; set; }

    }

}
