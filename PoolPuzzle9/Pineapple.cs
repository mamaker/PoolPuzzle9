﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PoolPuzzle9
{
    class Pineapple
    {
        const string workFolder = @"C:\MyOwnApps\GitLoc\HeadFirstCsharp\WorkFolder\";
        const string d = workFolder+"delivery.txt";
        public enum Fargo { North, South, East, West, Flamingo }

        public static void Main(string[] args)
        {
            StreamWriter o = new StreamWriter(workFolder+"order.txt");
            Pizza pz = new Pizza(new StreamWriter(d, true));
            pz.Idaho(Fargo.Flamingo);
            for (int w = 3; w >= 0; w--)
            {
                Pizza i = new Pizza(new StreamWriter(d, false));
                i.Idaho((Fargo)w);
                Party p = new Party(new StreamReader(d));
                p.HowMuch(o);
            }
            o.WriteLine("That’s all folks!");
            o.Close();
        }
    }
}
