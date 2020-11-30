namespace exam2_pt3
{
    public class WRStats : IPlayerStats
    {
        public string ID {get; set;}
        
        public double ReceivingYards {get; set;}
        public double RushingYards {get; set;}
        public int ReceivingTDs {get; set;}
        public int RushingTDs {get; set;}

        public override string ToString(){
            return ($"WR {ID}\tReceiving Yards\t{ReceivingYards}\tReceiving TDs\t{ReceivingTDs}\tRushingYards\t{RushingYards}\tRushing TDs\t{RushingTDs}");
        }
    }
}