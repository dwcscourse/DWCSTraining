using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class MerzedesFactory : Factory
    {
        public override Bus CreateBus(double load, string model, string regNumber)
        {
            return new MerzedesBus(load, model, regNumber);
        }

        public override Hatchback CreateHatchback(int numberOfSeats, string model, string regNumber)
        {
            return new MerzedesHatchback(numberOfSeats, model, regNumber);
        }
    }
}
