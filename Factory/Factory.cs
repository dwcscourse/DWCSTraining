using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public abstract class Factory
    {
        public abstract Bus CreateBus(double load, string model, string regNumber);
        public abstract Hatchback CreateHatchback(int numberOfSeats, string model, string regNumber);

    }
}
