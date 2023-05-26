using System;

namespace Kuas
{
    
    public class Player
    {
        private String playerName;
        public string PlayerName
        {
            get { return playerName; }
            set { playerName = value; }
        }
        private String playerImage;
        public string PlayerImage 
        {
            get { return playerImage; }
            set { playerImage = value; }
        }
       
        public int PlayerRate { get; set; }

        private String playerPrice;
        public string PlayerPrice
        {
            get { return playerPrice; }
            set { playerPrice = value; }
        }

        private String playerAge;
        public string PlayerAge
        {
            get { return playerAge; }
            set { playerAge = value; }
        }

        private int playerShirtNumber;
        public int PlayerShirtNumber
        {
            get { return playerShirtNumber; }
            set { playerShirtNumber = value; }
        }

        private String playerRole;
        public string PlayerRole
        {
            get { return playerRole; }
            set { playerRole = value; }
        }

        private String playerClubImage;
        public string PlayerClubImage
        {
            get { return playerClubImage; }
            set { playerClubImage = value; }
        }

        private String playerClub;
        public string PlayerClub
        {
            get { return playerClub; }
            set { playerClub = value; }
        }

        private String playerLeague;
        public string PlayerLeague
        {
            get { return playerLeague; }
            set { playerLeague = value; }
        }

        private int matchPlayed;
        public int MatchPlayed
        {
            get { return matchPlayed; }
            set { matchPlayed = value; }
        }

        private String minuteplayed;
        public string MinutePlayed
        {
            get { return minuteplayed; }
            set { minuteplayed = value; }
        }

        private int goals;
        public int Goals
        {
            get { return goals; }
            set { goals = value; }
        }

        private int assists;
        public int Assists
        {
            get { return assists; }
            set { assists = value; }
        }

        private int yellowCard;
        public int YellowCard
        {
            get { return yellowCard; }
            set { yellowCard = value; }
        }

        private int redCards;
        public int RedCards
        {
            get { return redCards; }
            set { redCards = value; }
        }

        private String countryBirth;
        public string CountryBirth
        {
            get { return countryBirth; }
            set { countryBirth = value; }
        }

        private String preferredFoot;
        public string PreferredFoot
        {
            get { return preferredFoot; }
            set { preferredFoot = value; }
        }

        private String continentOfBirth;
        public string ContinentOfBirth
        {
            get { return continentOfBirth; }
            set { continentOfBirth = value; }
        }

        private String regionOfBirth;
        public string RegionOfBirth
        {
            get { return regionOfBirth; }
            set { regionOfBirth = value; }
        }

        private String weight;
        public string Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        private String height;
        public string Height
        {
            get { return height; }
            set { height = value; }
        }

        private String status;
        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        private String currentClub;
        public string CurrentClub
        {
            get { return currentClub; }
            set { currentClub = value; }
        }

        private String currentCompetition;
        public string CurrentCompetition
        {
            get { return currentCompetition; }
            set { currentCompetition = value; }
        }

        private String previousClub;
        public string PreviousClub
        {
            get { return previousClub; }
            set { previousClub = value; }
        }

        private String previousCompetition;
        public string PreviousCompetition
        {
            get { return previousCompetition; }
            set { previousCompetition = value; }
        }

        private int mostCommonShirtNumber;
        public int MostCommonShirtNumber
        {
            get { return mostCommonShirtNumber; }
            set { mostCommonShirtNumber = value; }
        }

        private String otherShirtNumbers;
        public string OtherShirtNumbers
        {
            get { return otherShirtNumbers; }
            set { otherShirtNumbers = value; }
        }

        private int stamina;
        public int Stamina
        {
            get { return stamina; }
            set { stamina = value; }
        }

        private int pace;
        public int Pace
        {
            get { return pace; }
            set { pace = value; }
        }

        private int defender;
        public int Defender
        {
            get { return defender; }
            set { defender = value; }
        }

        private int shot;
        public int Shot
        {
            get { return shot; }
            set { shot = value; }
        }
        private int pass;
        public int Pass
        {
            get { return pass; }
            set { pass = value; }
        }

        public int Dribbling { get; set; }
    }
}
