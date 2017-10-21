using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantool
{
    class Calculate
    {
        //解析
        public static List<string> Decode(string line)
        {
            List<string> list = new List<string>();
            Candata can = new Candata();
            can.getCandata(line);
            string mid = can.id_16;
            string data = can.data;

            return list;
        }
        //设置
        public static string Put()
        {
            return "";
        }
    }
}
