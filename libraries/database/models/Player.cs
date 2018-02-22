using System;
using System.Net;
using System.ComponentModel;
using System.Xml.Serialization;

using Libraries.empire;
using Libraries.player;
using Libraries.database.models.player;


namespace Libraries.database.models
{

    /// <summary>
    /// Player model
    /// </summary>

    [XmlRoot(ElementName = "Player")]
    public class ModelPlayer : ModelBase
    {

        public ModelPlayer()
        {

            Gamecurrencys = new ModelPlayerGamecurrencys();
            Settings = new ModelPlayerSettings();
            Mailmessages = new PlayerMails();
            Vault = new ModelPlayerVault();

        }        

        [XmlAttribute(AttributeName = "Id")]
        public long Id { get; set; }

        [XmlElement(ElementName = "Name")]
        [DefaultValue(null)]
        public string Name { get; set; }

        [XmlElement(ElementName = "Password")]
        [DefaultValue(null)]
        public string Password { get; set; }

        [XmlElement(ElementName = "Role")]
        [DefaultValue(1)]
        public int Role { get; set; }

        [XmlElement(ElementName = "Ban")]
        public bool Ban { get; set; }

        [XmlElement(ElementName = "Lastsave")]
        public DateTime Lastsave = DateTime.UtcNow;

        [XmlElement(ElementName = "GameCurrencys")]
        public ModelPlayerGamecurrencys Gamecurrencys { get; set; }

        [XmlElement(ElementName = "Settings")]
        public ModelPlayerSettings Settings { get; set; }

        [XmlElement(ElementName = "MailMessages")]
        public PlayerMails Mailmessages { get; set; }

        [XmlElement(ElementName = "EmpireVault")]
        public ModelPlayerVault Vault { get; set; }

        [XmlIgnore]
        public string SessionAuthentication { get; set; }

        [XmlIgnore]
        public string SessionChat { get; set; }

        [XmlIgnore]
        public string SessionGame { get; set; }

        [XmlIgnore]
        public IPAddress Ip { get; set; }

        [XmlIgnore]
        private Empire _Empire;

        [XmlIgnore]
        public Empire Empire
        {

            get
            {

                if (_Empire == null)
                {

                    _Empire = Database.Empires.Get(Id);

                }

                return _Empire;

            }

        }

    }

}