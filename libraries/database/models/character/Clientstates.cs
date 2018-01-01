using System.Xml.Serialization;
using System.Collections.Generic;


namespace Libraries.database.models.character
{

    /// <summary>
    /// Character clientstates model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "clientstates")]
    public class ModelCharacterClientStates
    {

        [XmlElement(ElementName = "clientState")]
        public List<ModelCharacterClientState> ClientState { get; set; }

    }

}
