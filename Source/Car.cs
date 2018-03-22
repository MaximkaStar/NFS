using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Source
{
        public delegate void Finish(Car car);
        public abstract class Car
        {
            public Car()
            {
                Post = 0;
                ChangeVelocity();
            }
            protected const int MIN_SPEED = 1;
            private const int FIN_LINE = 100;

            public event Finish Winner;
            public string NickName { get; set; }
            public int Post { get; set; }
            public int Velocity { get;  set; }

            public abstract void ChangeVelocity();
            public bool Motion()
            {
                Post += Velocity;
                ChangeVelocity();
                if (Post >= FIN_LINE)
                {
                    Winner(this);
                    return true;
                }
                return false;
            }
            public override string ToString()
            {
                return string.Format("Position: {1,10} Name: {1,-15} ", Post, NickName);
            }
        }
    
}
