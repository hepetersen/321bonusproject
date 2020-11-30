namespace exam2_pt3
{
    public class QBStats : IPlayerStats
    {
        public string ID {get; set;}
        public double PassingYards {get; set;}
        public double RushingYards {get; set;}
        public int PassingTDs {get; set;}
        public int RushingTDs {get; set;}

        public override string ToString(){
            return ($"QB {ID}\tPassing Yards\t{PassingYards}\tPassing TDs\t{PassingTDs}\tRushingYards\t{RushingYards}\tRushing TDs\t{RushingTDs}");
        }
    }
}