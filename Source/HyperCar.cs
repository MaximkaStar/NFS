using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Source
{
    public class HyperCar : Car
    {
        public HyperCar(string Nickname = "") : base()
        {
           
        }
        private const int MAX_SPEED = 14;

        public override void ChangeVelocity()
        {
            Random random = new Random();
            Velocity = random.Next(MIN_SPEED, MAX_SPEED);
        }
    }
}
