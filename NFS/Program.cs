using Source;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace NFS
{
    class Program
    {
        static void Main(string[] args)
        {
            Race race = new Race();
            bool isRun = false;
            while (true)
            {
                if (isRun)
                {
                    Clear();
                    race.Cars.ForEach(car => WriteLine(car));
                    WriteLine("PRESS ENTER");
                    ReadLine();
                    if (race.MoveAll())
                    {
                        isRun = false;
                        ReadLine();
                    }
                }
                else
                {
                    Clear();
                    WriteLine("1 - BUS");
                    WriteLine("2 - HYPERCAR");

                    WriteLine("0 - START");
                    Write("MAKE YOUR CHOICE: ");

                    int select;
                    while (!int.TryParse(ReadLine(), out select))
                    {
                        Clear();
                        WriteLine("ERROR!");
                    }

                    if (select >= 1 && select <= 2)
                    {
                        Write("ENTER NAME: ");
                        
                        string Nickname = ReadLine();
                        switch (select)
                        {
                            case 1: race.Cars.Add(new Bus(Nickname)); break;
                            case 2: race.Cars.Add(new HyperCar(Nickname)); break;
                        }
                    }
                    else if (select == 0)
                    {
                        isRun = true;
                        race.StartRace();
                    }
                    else
                    {
                        Clear();
                        WriteLine("ERROR");
                        ReadLine();
                    }
                }
            }
        }
    }
    
}
