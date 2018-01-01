using System.ComponentModel;
using System.Collections.Generic;
using System.Xml.Serialization;

using Libraries.enums;
using Libraries.database.models.civilization;


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
        public int Alliedid { get; set; }

        [XmlElement(ElementName = "alliedotherid")]
        public int Alliedotherid { get; set; }

        [XmlElement(ElementName = "allowedcharactertypes")]
        public ModelCivilizationAllowedcharactertypes Allowedcharactertypes { get; set; }

        [XmlElement(ElementName = "buildingefficiency")]
        [DefaultValue(null)]
        public string Buildingefficiency { get; set; }

        [XmlElement(ElementName = "capitolbldgunittype")]
        [DefaultValue(null)]
        public string Capitolbldgunittype { get; set; }

        [XmlElement(ElementName = "civid")]
        [DefaultValue(Civilizations.Generic)]
        public Civilizations CivId { get; set; }

        [XmlElement(ElementName = "civmatchingid")]
        [DefaultValue(CivilizationsPrefix.Generic)]
        public CivilizationsPrefix Civmatchingid { get; set; }

        [XmlElement(ElementName = "contentpack")]
        [DefaultValue(null)]
        public string Contentpack { get; set; }

        [XmlElement(ElementName = "courierprotoname")]
        [DefaultValue(null)]
        public string Courierprotoname { get; set; }

        [XmlElement(ElementName = "culture")]
        [DefaultValue(null)]
        public string Culture { get; set; }

        [XmlElement(ElementName = "displaynameid")]
        public int Displaynameid { get; set; }

        [XmlElement(ElementName = "ignorecommandbutton")]
        public ModelCivilizationIgnorecommandbutton Ignorecommandbutton { get; set; }

        [XmlElement(ElementName = "introvideo")]
        [DefaultValue(null)]
        public string Introvideo { get; set; }

        [XmlElement(ElementName = "levelupsound")]
        [DefaultValue(null)]
        public string Levelupsound { get; set; }

        [XmlElement(ElementName = "main")]
        public int Main { get; set; }

        [XmlElement(ElementName = "mapx")]
        [DefaultValue(null)]
        public string Mapx { get; set; }

        [XmlElement(ElementName = "mapy")]
        [DefaultValue(null)]
        public string Mapy { get; set; }

        [XmlElement(ElementName = "name")]
        [DefaultValue(null)]
        public string Name { get; set; }

        [XmlElement(ElementName = "namestringid")]
        public int Namestringid { get; set; }

        [XmlElement(ElementName = "objectivecompletesound")]
        [DefaultValue(null)]
        public string Objectivecompletesound { get; set; }

        [XmlElement(ElementName = "offertype")]
        public OfferTypesPrefix Offertype { get; set; }

        [XmlElement(ElementName = "persistentcity")]
        [DefaultValue(null)]
        public string Persistentcity { get; set; }

        [XmlElement(ElementName = "portrait")]
        [DefaultValue(null)]
        public string Portrait { get; set; }

        [XmlElement(ElementName = "postindustrialtech")]
        [DefaultValue(null)]
        public string Postindustrialtech { get; set; }

        [XmlElement(ElementName = "postimperialtech")]
        [DefaultValue(null)]
        public string Postimperialtech { get; set; }

        [XmlElement(ElementName = "rollovernameid")]
        public int Rollovernameid { get; set; }

        [XmlElement(ElementName = "startingcities")]
        public ModelCivilizationStartingcities Startingcities { get; set; }

        [XmlElement(ElementName = "startingresources")]
        public ModelCivilizationStartingresources Startingresources { get; set; }

        [XmlElement(ElementName = "statsid")]
        [DefaultValue(null)]
        public string Statsid { get; set; }

        [XmlElement(ElementName = "towncenter")]
        [DefaultValue(null)]
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
