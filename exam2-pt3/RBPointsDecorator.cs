namespace exam2_pt3
{
    public class RBPointsDecorator : IPlayerStats
    {
        private RBStats rb;

        public RBPointsDecorator(RBStats rb)
        {
            this.rb = rb;
        }

        private double TotalPoints()
        {
            double points = rb.RushingYards / 10.0;
            points += rb.ReceivingYards / 10.0;
            points += rb.RushingTDs * 6;
            points += rb.ReceivingTDs * 6;

            return points;
        }

        public override string ToString()
        {
            double points = TotalPoints();
            return ($"RB {rb.ID}\tReceiving Yards\t{rb.ReceivingYards}\tReceiving TDs\t{rb.ReceivingTDs}\tRushingYards\t{rb.RushingYards}\tRushing TDs\t{rb.RushingTDs}\tTotal Points\t{points}");
        }
    }
}