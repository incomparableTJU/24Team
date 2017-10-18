using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantool
{
    class Signal
    {
        public string signalName=null;
        public int startBit = 0;
        public int bitLength = 0;
        //0: Motorola  1:Intel
        public int bitStyle = 0;
        public double A = 0;
        public double B = 0;
        //min:c max:D
        public double C = 0;
        public double D = 0;
        public string physicalUnit =null;
        public string[] nodeNames = null;
        
    }
}
