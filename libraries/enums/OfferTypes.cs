using System.Xml.Serialization;

namespace Libraries.enums
{

    public enum OfferTypes
    {

        [XmlEnum("eOfferNone")] eOfferNone = 0,

        // Greek civ
        [XmlEnum("eOfferCivGreek")] eOfferCivGreek = 1,

        // Egyptian civ
        [XmlEnum("eOfferCivEgyptian")] eOfferCivEgyptian = 2,

        // Norse civ
        [XmlEnum("eOfferCivNorse")] eOfferCivNorse = 7,

        // Babylonian civ
        [XmlEnum("eOfferCivBabylonian")] eOfferCivBabylonian = 6,

        // Roman civ
        [XmlEnum("eOfferCivRoman")] eOfferCivRoman = 5,

        // Persian civ
        [XmlEnum("eOfferCivPersian")] eOfferCivPersian = 4,

        // Celtic civ
        [XmlEnum("eOfferCivCeltic")] eOfferCivCeltic = 3,

        // Empire Vault
        [XmlEnum("eOfferEmpireInventory")] eOfferEmpireInventory = 39,

        // Northern Quest Booster
        [XmlEnum("eOfferBooster4")] eOfferBooster4 = 13,

        // Babylon Quest Booster
        [XmlEnum("eOfferBooster3")] eOfferBooster3 = 12,

        //  Skirmish
        [XmlEnum("eOfferBooster2")] eOfferBooster2 = 11,

        // Defense of Crete
        [XmlEnum("eOfferBooster1")] eOfferBooster1 = 10,

        [XmlEnum("eOfferEnd")] eOfferEnd = 46,
        [XmlEnum("eOfferSteamSpecial6")] eOfferSteamSpecial6 = 45,
        [XmlEnum("eOfferSteamSpecial5")] eOfferSteamSpecial5 = 44,
        [XmlEnum("eOfferSteamSpecial4")] eOfferSteamSpecial4 = 43,
        [XmlEnum("eOfferSteamSpecial3")] eOfferSteamSpecial3 = 42,
        [XmlEnum("eOfferSteamSpecial2")] eOfferSteamSpecial2 = 41,
        [XmlEnum("eOfferSteamSpecial1")] eOfferSteamSpecial1 = 40,        
        [XmlEnum("eOfferBundle6")] eOfferBundle6 = 38,
        [XmlEnum("eOfferBundle5")] eOfferBundle5 = 37,
        [XmlEnum("eOfferBundle4")] eOfferBundle4 = 36,
        [XmlEnum("eOfferBundle3")] eOfferBundle3 = 35,
        [XmlEnum("eOfferBundle2")] eOfferBundle2 = 34,
        [XmlEnum("eOfferBundle1")] eOfferBundle1 = 33,
        [XmlEnum("eOfferRetailStore2")] eOfferRetailStore2 = 32,
        [XmlEnum("eOfferRetailStore1")] eOfferRetailStore1 = 31,
        [XmlEnum("eOfferVanity12")] eOfferVanity12 = 30,
        [XmlEnum("eOfferVanity11")] eOfferVanity11 = 29,
        [XmlEnum("eOfferVanity10")] eOfferVanity10 = 28,
        [XmlEnum("eOfferVanity9")] eOfferVanity9 = 27,
        [XmlEnum("eOfferVanity8")] eOfferVanity8 = 26,
        [XmlEnum("eOfferVanity7")] eOfferVanity7 = 25,
        [XmlEnum("eOfferVanity6")] eOfferVanity6 = 24,
        [XmlEnum("eOfferVanity5")] eOfferVanity5 = 23,
        [XmlEnum("eOfferGreekVanity2")] eOfferGreekVanity2 = 22,
        [XmlEnum("eOfferGreekVanity1")] eOfferGreekVanity1 = 21,
        [XmlEnum("eOfferEgyptianVanity2")] eOfferEgyptianVanity2 = 20,
        [XmlEnum("eOfferEgyptianVanity1")] eOfferEgyptianVanity1 = 19,
        [XmlEnum("eOfferBooster9")] eOfferBooster9 = 18,
        [XmlEnum("eOfferBooster8")] eOfferBooster8 = 17,
        [XmlEnum("eOfferBooster7")] eOfferBooster7 = 16,
        [XmlEnum("eOfferBooster6")] eOfferBooster6 = 15,
        [XmlEnum("eOfferBooster5")] eOfferBooster5 = 14,
        [XmlEnum("eOfferCivMoreThan1")] eOfferCivMoreThan1 = 9,
        [XmlEnum("eOfferCivMatching")] eOfferCivMatching = 8,        

    }

}
