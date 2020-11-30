using System.Collections.Generic;

namespace exam2_pt3
{
    public interface IGetStats
    {
        List<IPlayerStats> GetQBStats();
        List<IPlayerStats> GetRBStats();
        List<IPlayerStats> GetWRStats();
    }
}