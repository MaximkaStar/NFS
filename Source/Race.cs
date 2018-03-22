using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Source
{
    public class Race
    {
        public Finish Winner = car =>
        {
            WriteLine("WINNER: " + car.NickName);
        };
        public Race()
        {
            Cars = new List<Car>();
        }
        public List<Car> Cars { get; set; }

        public bool MoveAll()
        {
            for (int i = 0; i < Cars.Count; i++)
            {
                if (Cars[i].Motion())
                {
                    WriteLine("END!");
                    Reset();
                    return true;
                }
            }
            return false;
        }

        public void StartRace()
        {
            Cars.ForEach(car => car.Winner += Winner);
        }
        private void Reset()
        {
            Cars.Clear();
        }
    }
}
