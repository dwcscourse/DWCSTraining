﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityWithPetsTD
{
    public interface IInhabitantWithBirthday
    {
        string Name { get; }
        DateTime Birthday { get; }
    }
}
