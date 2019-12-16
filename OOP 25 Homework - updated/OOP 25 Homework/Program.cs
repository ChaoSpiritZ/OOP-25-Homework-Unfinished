using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_25_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //RoundTable<Knight> RTK = new RoundTable<Knight>();

            //RTK.Add(new Knight("amik varze", "falador", "sir"));
            //RTK.Add(new Knight("yharim", "lihzhardia", "tyrant"));
            //RTK.Add(new Knight("kumstance", "varrock", "sir"));


            //RTK.InsertAt(3, new Knight("artorias", "lordran", "knight"));

            //List<Knight> roundedKnights = RTK.GetRounded(9);

            //foreach (Knight item in roundedKnights)
            //{
            //    Console.WriteLine(item.Name);
            //}

            RoundTable<Knight> RTK = new RoundTable<Knight>();
            RTK[0] = new Knight()
        }
    }
}
