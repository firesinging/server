using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Xml.Serialization;

using Libraries.database.models.questgiver;

using Libraries.helpers.general;
using Libraries.helpers.xml;


namespace Libraries.database.models
{

    /// <summary>
    /// Questgiver model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "questgiver")]
    public class ModelQuestgiver : ModelBase
    {

        public ModelQuestgiver()
        {

            Overrides = new ModelQuestgiverOverrides();
            Location = new ModelQuestgiverLocation();
            Spawntrigger = new ModelQuestgiverSpawntrigger();
            Despawntrigger = new ModelQuestgiverDespawntrigger();

        }

        [XmlElement(ElementName = "name")]
        [DefaultValue(null)]
        public string Name { get; set; }

        [XmlElement(ElementName = "placeunittype")]
        [DefaultValue(null)]
        public string Placeunittype { get; set; }

        [XmlElement(ElementName = "status")]
        [DefaultValue(null)]
        public string Status { get; set; }

        [XmlElement(ElementName = "maptype")]
        [DefaultValue(null)]
        public string Maptype { get; set; }

        [XmlElement(ElementName = "overrides")]
        public ModelQuestgiverOverrides Overrides { get; set; }

        [XmlElement(ElementName = "location")]
        public ModelQuestgiverLocation Location { get; set; }

        [XmlElement(ElementName = "spawntrigger")]
        public ModelQuestgiverSpawntrigger Spawntrigger { get; set; }

        [XmlElement(ElementName = "despawntrigger")]
        public ModelQuestgiverDespawntrigger Despawntrigger { get; set; }

        [XmlElement(ElementName = "greetingstringid")]
        public int Greetingstringid { get; set; }

        [XmlElement(ElementName = "greetingsoundset")]
        [DefaultValue(null)]
        public string Greetingsoundset { get; set; }

        [XmlElement(ElementName = "farewellsoundset")]
        [DefaultValue(null)]
        public string Farewellsoundset { get; set; }

        [XmlElement(ElementName = "artset")]
        [DefaultValue(null)]
        public string Artset { get; set; }

        [XmlAttribute(AttributeName = "region")]
        public int Region { get; set; }

        [XmlAttribute(AttributeName = "altregion")]
        public int Altregion { get; set; }

        [XmlIgnore]
        public new string ToXml
        {

            get
            {

                QuestgiverBaseOverride QuestgiverOverride = new QuestgiverBaseOverride();

                Helper.CopyPropertiesTo(this, QuestgiverOverride, new List<string>() { "Overrides" });

                if (Overrides.Items.Count > 0)
                {

                    foreach (ModelQuestgiverOverride Override in Overrides.Items)
                    {

                        switch (Override.Key.ToLower())
                        {

                            case "displaynameid":

                                QuestgiverOverride.Overrides.DisplayNameId = Override.Value;

                                break;

                            case "shortrollovertextid":

                                QuestgiverOverride.Overrides.ShortRolloverTextId = Override.Value;

                                break;

                            case "animfile":

                                QuestgiverOverride.Overrides.AnimFile = Override.Value;

                                break;

                            case "icon":

                                QuestgiverOverride.Overrides.Icon = Override.Value;

                                break;

                            case "portraiticon":

                                QuestgiverOverride.Overrides.PortraitIcon = Override.Value;

                                break;

                            case "visualscale":

                                QuestgiverOverride.Overrides.VisualScale = Override.Value;

                                break;

                            default:

                                throw new ArgumentOutOfRangeException($"Database::ModelQuestgiver - Unknown override. Override: {Override.Key.ToLower()}");

                        }                        

                    }                    

                    return XMLHelper.SerializeObjectToXml(QuestgiverOverride);
                    
                }

                return XMLHelper.SerializeObjectToXml(this);

            }

        }

    }

}