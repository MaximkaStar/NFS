using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Source
{
    public class Bus : Car
    {
        public Bus(string Nickname = "") : base()
        {
           
        }
        private const int MAX_SPEED = 6;

        public override void ChangeVelocity()
        {
            Random random = new Random();
            Velocity = random.Next(MIN_SPEED, MAX_SPEED);
        }
    }
}
