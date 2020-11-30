namespace exam2_pt3
{
    public class QBPointsDecorator : IPlayerStats
    {
        private QBStats qb;

        public QBPointsDecorator(QBStats qb)
        {
            this.qb = qb;
        }

        private double TotalPoints()
        {
            double points = qb.RushingYards / 10.0;
            points += qb.PassingYards / 25.0;
            points += qb.RushingTDs * 6;
            points += qb.PassingTDs * 4;

            return points;
        }

        public override string ToString()
        {
            double points = TotalPoints();
            return ($"QB {qb.ID}\tPassing Yards\t{qb.PassingYards}\tPassing TDs\t{qb.PassingTDs}\tRushingYards\t{qb.RushingYards}\tRushing TDs\t{qb.RushingTDs}\tTotalPoints\t{points}");
        }
    }
}