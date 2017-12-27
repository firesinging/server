using System.Collections.Generic;
using System.Xml.Serialization;

using Libraries.enums;


namespace Libraries.database.models
{
    /// <summary>
    /// Civilization model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "civ")]
    public class ModelCivilization
    {

        [XmlElement(ElementName = "agetech")]
        public List<ModelCivilizationAgetech> Agetech { get; set; }

        [XmlElement(ElementName = "alliedid")]
        public string Alliedid { get; set; }

        [XmlElement(ElementName = "alliedotherid")]
        public string Alliedotherid { get; set; }

        [XmlElement(ElementName = "allowedcharactertypes")]
        public ModelCivilizationAllowedcharactertypes Allowedcharactertypes { get; set; }

        [XmlElement(ElementName = "buildingefficiency")]
        public string Buildingefficiency { get; set; }

        [XmlElement(ElementName = "capitolbldgunittype")]
        public string Capitolbldgunittype { get; set; }

        [XmlElement(ElementName = "civid")]
        public Civilizations CivId { get; set; }

        [XmlElement(ElementName = "civmatchingid")]
        public string Civmatchingid { get; set; }

        [XmlElement(ElementName = "contentpack")]
        public string Contentpack { get; set; }

        [XmlElement(ElementName = "courierprotoname")]
        public string Courierprotoname { get; set; }

        [XmlElement(ElementName = "culture")]
        public string Culture { get; set; }

        [XmlElement(ElementName = "displaynameid")]
        public string Displaynameid { get; set; }

        [XmlElement(ElementName = "ignorecommandbutton")]
        public ModelCivilizationIgnorecommandbutton Ignorecommandbutton { get; set; }

        [XmlElement(ElementName = "introvideo")]
        public string Introvideo { get; set; }

        [XmlElement(ElementName = "levelupsound")]
        public string Levelupsound { get; set; }

        [XmlElement(ElementName = "main")]
        public string Main { get; set; }

        [XmlElement(ElementName = "mapx")]
        public string Mapx { get; set; }

        [XmlElement(ElementName = "mapy")]
        public string Mapy { get; set; }

        [XmlElement(ElementName = "name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "namestringid")]
        public string Namestringid { get; set; }

        [XmlElement(ElementName = "objectivecompletesound")]
        public string Objectivecompletesound { get; set; }

        [XmlElement(ElementName = "offertype")]
        public string Offertype { get; set; }

        [XmlElement(ElementName = "persistentcity")]
        public string Persistentcity { get; set; }

        [XmlElement(ElementName = "portrait")]
        public string Portrait { get; set; }

        [XmlElement(ElementName = "postindustrialtech")]
        public string Postindustrialtech { get; set; }

        [XmlElement(ElementName = "postimperialtech")]
        public string Postimperialtech { get; set; }

        [XmlElement(ElementName = "rollovernameid")]
        public string Rollovernameid { get; set; }

        [XmlElement(ElementName = "startingcities")]
        public ModelCivilizationStartingcities Startingcities { get; set; }

        [XmlElement(ElementName = "startingresources")]
        public ModelCivilizationStartingresources Startingresources { get; set; }

        [XmlElement(ElementName = "statsid")]
        public string Statsid { get; set; }

        [XmlElement(ElementName = "towncenter")]
        public string Towncenter { get; set; }

        [XmlElement(ElementName = "townstartingunit")]
        public List<string> Townstartingunit { get; set; }

        [XmlElement(ElementName = "ui")]
        public ModelCivilizationUi Ui { get; set; }

        [XmlElement(ElementName = "unalliedid")]
        public string Unalliedid { get; set; }

        [XmlElement(ElementName = "unitregen")]
        public ModelCivilizationUnitregen Unitregen { get; set; }

        [XmlElement(ElementName = "wall")]
        public List<ModelCivilizationWall> Wall { get; set; }

        [XmlIgnore]
        public string Source { get; set; }

    }

}
