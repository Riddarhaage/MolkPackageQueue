﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MolkPackageQueue
{
    class PackageFactory
    {
        Random randomizer = new Random();
        public Package CreatePackage(Priority prio)
        {
            //use randomizer to send in a prio-enum
            return new Package(prio);
        }
    }
}
