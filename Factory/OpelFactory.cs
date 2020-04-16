using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class OpelFactory : IFactory
    {
        public Bus CreateBus(double load, string model, string regNumber)
        {
            return new OpelBus(load, model, regNumber);
        }

        public Hatchback CreateHatchback(int numberOfSeats, string model, string regNumber)
        {
            return new OpelHatchback(numberOfSeats, model, regNumber);
        }       

    }
}
