using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantool
{
    class Message
    {
        public int messageId = 0;
        public string messageName = null;
        public int DLC = 8;
        public string[] nodeNameECU = null;
        public List<Signal> signals=new List<Signal >();


    }
}
