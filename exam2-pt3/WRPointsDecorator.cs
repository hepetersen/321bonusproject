namespace exam2_pt3
{ 
    public class WRPointsDecorator : IPlayerStats
    {
        private WRStats wr;

        public WRPointsDecorator(WRStats wr)
        {
            this.wr = wr;
        }

        private double TotalPoints()
        {
            double points = wr.RushingYards / 10.0;
            points += wr.ReceivingYards / 10.0;
            points += wr.RushingTDs * 6;
            points += wr.ReceivingTDs * 6;

            return points;
        }

        public override string ToString()
        {
            double points = TotalPoints();
            return ($"WR {wr.ID}\tReceiving Yards\t{wr.ReceivingYards}\tReceiving TDs\t{wr.ReceivingTDs}\tRushingYards\t{wr.RushingYards}\tRushing TDs\t{wr.RushingTDs}\tTotal Points\t{points}");
        }
    }
}