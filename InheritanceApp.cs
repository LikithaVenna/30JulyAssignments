using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{
    class Game
    {
        int numOfPlayers;
        string country;
        public int NumOfPlayers
        {
            get { return numOfPlayers; }
            set { numOfPlayers = value; }
        }
        public string Country
        {
            get { return country; }
            set { country = value; }
        }
        public Game()
        { }
        public Game(int _numOfPlayers, string _country)
        {
            numOfPlayers = _numOfPlayers;
            country = _country;
        }
        public string WorldCup()
        {
            DateTime now = DateTime.Today;
            return "WordCup : "+ now.ToString("yyyy");
        }
    }
    class Cricket : Game
    {
        string coachName;

        public string CoachName
        {
            get { return coachName; }
            set { coachName = value; }
        }
        public Cricket()
        {}
        public Cricket(int _numOfplayers,string _country,string _coachName):base(_numOfplayers,_country)
        {
            coachName = _coachName;
        }
    }
    class Football : Game
    {
        string leagueName;
        public string LeagueName
        {
            get { return leagueName; }
            set { leagueName = value; }
        }
        public Football()
        {}
        public Football(int _numOfplayers,string _country,string _leagueName)
            :base(_numOfplayers,_country)
        {
            leagueName = _leagueName;
        }
    }
    class ShowGameDetails
    {
        public void ShowCricketDetails()
        {
            Console.WriteLine("----------CRICKET INFORMATION-----------");
        }
        public void ShowFootBallDetails()
        {
            Console.WriteLine("---------FOOTBALL INFORMATION-----------");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cricket c = new Cricket();
            c.Country = "India";
            c.NumOfPlayers = 11;
            c.CoachName = "John Wright";
            ShowGameDetails sh = new ShowGameDetails();
            sh.ShowCricketDetails();
            Console.WriteLine("Country : {0} No. Of Players : {1} Coach Name : {2}",c.Country,c.NumOfPlayers,c.CoachName);
            c.Country = "Australia";
            c.NumOfPlayers = 11;
            c.CoachName = "John Buchanan";
            Console.WriteLine("Country : {0} No. Of Players : {1} Coach Name : {2}", c.Country, c.NumOfPlayers, c.CoachName);
            sh.ShowFootBallDetails();
            Football f = new Football();
            f.Country = "Spain";
            f.NumOfPlayers = 14;
            f.LeagueName = "Spanish League";
            Console.WriteLine("Country : {0} No. Of Players : {1} Coach Name : {2}", f.Country, f.NumOfPlayers, f.LeagueName);
            f.Country = "England";
            f.NumOfPlayers = 13;
            f.LeagueName = "English Premiur League";
            Console.WriteLine("Country : {0} No. Of Players : {1} Coach Name : {2}", f.Country, f.NumOfPlayers, f.LeagueName);
            Game g = new Game();
            Console.WriteLine("  ");
            Console.WriteLine("Australia have Won Cricket {0}",g.WorldCup());
            Console.WriteLine("Spain have Won Cricket {0}", g.WorldCup());
            Console.ReadLine();
        }
    }
}
