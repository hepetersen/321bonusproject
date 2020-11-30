using System;
using System.Collections.Generic;

namespace exam2_pt3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This weeks QB stats are below!");
            //IGetStats statsObj = new NormalProvider();
            IGetStats statsObj = new NewProviderAdapter(new NewProvider());
            List<IPlayerStats> qbStats = statsObj.GetQBStats();
            foreach(IPlayerStats qb in qbStats){
                Console.WriteLine(qb.ToString());
            }

            Console.WriteLine("\nThis weeks WR stats are below!");
            List<IPlayerStats> wrStats = statsObj.GetWRStats();
            foreach(IPlayerStats wr in wrStats){
                Console.WriteLine(wr.ToString());
            }

            Console.WriteLine("\nThis weeks RB stats are below!");
            List<IPlayerStats> rbStats = statsObj.GetRBStats();
            foreach(IPlayerStats rb in rbStats){
                Console.WriteLine(rb.ToString());
            }
        }
    }
}
