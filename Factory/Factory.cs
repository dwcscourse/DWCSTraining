using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public interface IFactory
    {
        Bus CreateBus(double load, string model, string regNumber);
        Hatchback CreateHatchback(int numberOfSeats, string model, string regNumber);
    }
}
