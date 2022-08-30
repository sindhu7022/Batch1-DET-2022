using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal interface ICar
    {
        int GetPrice(string name);
    }

    class BMW : ICar
    {
        public int GetPrice(string name)
        {
            if (name == "M3")
                return 1300000;
            else if (name == "X7")
                return 9600000;
            else
                return 100000;
        }
    }

    class Hyundai : ICar
    {
        public int GetPrice(string name)
        {
            if (name == "i20")
                return 730000;
            else if (name == "creta")
                return 1000000;
            else
                return 700000;
        }
    }
}
