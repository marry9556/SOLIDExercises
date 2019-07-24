using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    public class MotorCar : ICar
    {
        private Engine engine = new Engine();
        public void accelerate()
        {
            engine.Accelerate(1000);
        }

        public void turnOnEngine()
        {
            engine.On();
        }
    }
}
