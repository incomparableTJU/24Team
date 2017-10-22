using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantool
{
    class Candata
    {
        public string flag { get; set; }
        public string id_16 { get; set; }
        public int len { get; set; }
        public string data { get; set; }
        //用来封装<物理量，物理值>并进行显示用
        public Dictionary<string,string> dic { get; set; }

        public Candata()
        {
            flag = "";
            id_16 = "";
            len = 8;
            data = "";
        }
        //对Candata设置显示物理量和物理值的方法
        //public 

        public Candata getCandata(string line)
        {
            //Message m = new Message();
            this.flag = line.Substring(0, 1);
            this.id_16 = line.Substring(1, 3);
            this.len = int.Parse(line.Substring(4, 1));
            this.data = line.Substring(5, 16);
            return this;
        }
    }
}
