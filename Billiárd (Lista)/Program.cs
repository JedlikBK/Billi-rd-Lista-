using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billiárd__Lista_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> golyók = new List<int>();
            Kezdés(golyók);
            int leesett = Leesősolsoló(golyók);
            Kiíró(golyók);
            do
            {

            } while (leesett != 8);
            

            //for (int i = 0; i < golyók.Count; i++)
            //{
            //    Console.Write(golyók[i]+" ");
            //}
            Console.ReadKey();
        }

        private static void Kiíró(List<int> golyók)
        {
            foreach (int item in golyók)
            {
                Console.Write(item+" ");
            }
        }

        private static int Leesősolsoló(List<int> golyók)     // Hányadik esett le
        {
            int leesett = 0;
            Random gép = new Random();
            
            leesett = gép.Next(golyók.Count);
            golyók.Remove(leesett);
            return golyók[leesett];
        }

        private static void Kezdés(List<int> golyók)
        {
            for (int i = 1; i <= 15; i++)
            {
                golyók.Add(i);
            }
        }
    }
}
