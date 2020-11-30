using System.Collections.Generic;

namespace exam2_pt3
{
    public class NormalProvider : IGetStats
    {
        public List<IPlayerStats> GetQBStats()
        {
            List<IPlayerStats> qbStats = new List<IPlayerStats>();
            qbStats.Add(new QBStats(){ID="QB1", PassingYards = 175, 
                        RushingYards=22.5, PassingTDs=1, RushingTDs=0});
            qbStats.Add(new QBStats(){ID="QB2", PassingYards = 305.5, 
                        RushingYards=2.5, PassingTDs=3, RushingTDs=1});
            qbStats.Add(new QBStats(){ID="QB3", PassingYards = 205.5, 
                        RushingYards=12.5, PassingTDs=2, RushingTDs=1});
            
            return qbStats;
        }

        public List<IPlayerStats> GetRBStats()
        {
            List<IPlayerStats> rbStats = new List<IPlayerStats>();
            rbStats.Add(new RBStats(){ID="RB1", ReceivingYards = 25, 
                        RushingYards=72.5, ReceivingTDs=1, RushingTDs=0});
            rbStats.Add(new RBStats(){ID="RB1", ReceivingYards = 25, 
                        RushingYards=172.5, ReceivingTDs=0, RushingTDs=1});
            rbStats.Add(new RBStats(){ID="RB1", ReceivingYards = 25, 
                        RushingYards=102.0, ReceivingTDs=1, RushingTDs=2});
            return rbStats;
        }

        public List<IPlayerStats> GetWRStats()
        {
            List<IPlayerStats> wrStats = new List<IPlayerStats>();
            wrStats.Add(new WRStats(){ID="WR1", ReceivingYards = 72, 
                        RushingYards=5.25, ReceivingTDs=1, RushingTDs=0});
            wrStats.Add(new WRStats(){ID="WR1", ReceivingYards = 25, 
                        RushingYards=0, ReceivingTDs=0, RushingTDs=0});
            wrStats.Add(new WRStats(){ID="WR1", ReceivingYards = 125, 
                        RushingYards=12.0, ReceivingTDs=2, RushingTDs=0});
            return wrStats;
        }
    }
}