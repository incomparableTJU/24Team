using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantool
{
    class Signal
    {
        public string signal { get; set; }
        public string signalName { get; set; }
        public int startBit { get; set; }
        public int bitLength { get; set; }
        //0: Motorola  1:Intel
        public int bitStyle { get; set; }
        public double A { get; set; }
        public double B { get; set; }
        //min:c max:D
        public double C { get; set; }
        public double D { get; set; }
        public string physicalUnit { get; set; }
        public string[] nodeNames { get; set; }

        public Signal()
        {
            signal = null;
            signalName = null;
            startBit = 0;
            bitLength = 0;
            bitStyle = 0;
            A = 0.0;
            B = 0.0;
            C = 0.0;
            D = 0.0;
            physicalUnit = null;
            nodeNames = null;

        }

        //将string解析到类Message中
        public Signal getSignal(string line)
        {
            //Signal s = new Signal();
            this.signal = line;
            string[] temp = line.Split(' ');
            this.signalName = temp[2].Substring(4, temp[2].Length - 4);

            string[] bit = temp[4].Split(new char[3] { '|', '@', '+' });
            this.startBit = int.Parse(bit[0]);
            this.bitLength = int.Parse(bit[1]);
            this.bitStyle = int.Parse(bit[2]);

            string[] value = temp[5].Split(',');
            this.A = double.Parse(value[0].Substring(1, value[0].Length - 1));
            this.B = double.Parse(value[1].Substring(0, value[1].Length - 1));

            string[] range = temp[6].Split('|');
            this.C = double.Parse(range[0].Substring(1, range[0].Length - 1));
            this.D = double.Parse(range[1].Substring(0, range[1].Length - 1));

            this.physicalUnit = temp[7].Substring(1, temp[7].Length - 2);
            this.nodeNames = temp[9].Split(',');

            return this;
        }
    }
}
