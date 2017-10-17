using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace read
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] id;
            id = new string[100];
            string[,] signal;
            signal = new string[100, 1000];
            FileStream fsRead = new FileStream("D:\\learngit\\24Team\\cantooltree\\CanTool\\CanTool\\canmsg.txt", FileMode.Open);
            StreamReader reader = new StreamReader(fsRead);
           // StreamReader readcopy = reader;
            //int fsLen = (int)fsRead.Length;
            string str;
            int m = 0, n = 0;
            do
            {
                str = reader.ReadLine();
                if (str == null)
                    break;

                Console.WriteLine(str);
              
                int i, j;
              
               
                if (str[0].Equals('B'))
                {
                    i = str.IndexOf("BO_ ");   //索引为0
                    j = str.IndexOf(" ", 4, 9);//索引为7
                    id[m] = str.Substring(i + 4, j - i - 4);
                    Console.WriteLine(id[m]);
                    m++;
                 
                }
                if (str.Length > 1&&str[1].Equals('S'))
                {
                    i = str.IndexOf("_", 4, 9);//索引为8
                    j = str.IndexOf(":");
                    signal[m, n] = str.Substring(i + 1, j - i - 1);
                    Console.WriteLine(signal[m, n]);
                    n++;
                }
            }
            while (str != null );             
        }
    }
}
