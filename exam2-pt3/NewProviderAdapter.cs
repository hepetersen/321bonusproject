using System;
using System.Collections.Generic;

namespace exam2_pt3
{
    public class NewProviderAdapter : IGetStats
    {
        private NewProvider stats;

        public NewProviderAdapter(NewProvider stats)
        {
            this.stats = stats;
        }
        
        public List<IPlayerStats> GetQBStats()
        {
            List<OffensiveStats> oStats = stats.GetOffensiveStats();
            List<IPlayerStats> qbStats = new List<IPlayerStats>();
            foreach(OffensiveStats player in oStats)
            {
                if(player.Position == "QB")
                {
                    QBStats tempPlayer = new QBStats(){ID=player.ID, PassingYards=player.PassingYards, RushingYards=player.RushingYards, PassingTDs=player.PassingTDs, RushingTDs=player.RushingTDs};
                    qbStats.Add(new QBPointsDecorator(tempPlayer));
                }
            }
            return qbStats;
        }

        public List<IPlayerStats> GetRBStats()
        {
            List<OffensiveStats> oStats = stats.GetOffensiveStats();
            List<IPlayerStats> rbStats = new List<IPlayerStats>();
            foreach(OffensiveStats player in oStats)
            {
                if(player.Position == "RB")
                {
                    RBStats tempPlayer = new RBStats(){ID=player.ID,ReceivingYards = player.ReceivingYards, RushingYards=player.RushingYards, RushingTDs=player.RushingTDs, ReceivingTDs = player.ReceivingTDs};
                    rbStats.Add(new RBPointsDecorator(tempPlayer));
                }
            }
            return rbStats;
        }

        public List<IPlayerStats> GetWRStats()
        {
            List<OffensiveStats> oStats = stats.GetOffensiveStats();
            List<IPlayerStats> wrStats = new List<IPlayerStats>();
            foreach(OffensiveStats player in oStats)
            {
                if(player.Position == "WR")
                {
                    WRStats tempPlayer = new WRStats(){ID=player.ID, ReceivingYards = player.ReceivingYards, RushingYards=player.RushingYards, RushingTDs=player.RushingTDs, ReceivingTDs = player.ReceivingTDs};
                    wrStats.Add(new WRPointsDecorator(tempPlayer));
                }
            }
            return wrStats;
        }
    }
}