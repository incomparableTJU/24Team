using Cantool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cantool
{
    class Calculate
    {
        public static List<Message> database = new List<Message>();
        //解析
        public void loadData(List<Message> db)
        {
            database = db;
        }
        public Dictionary<string, string> Decode(string line)
        {

            Dictionary<string, string> dic = new Dictionary<string, string>();
            Candata can = new Candata();
            can.getCandata(line);
            string mid = can.id_16;
            string data = can.data;
            //返回的二进制数据
            string dealdata = storage(data);
            dic = decode(mid, dealdata);
            //MessageBox.Show(dic.Count().ToString());
            //dic的size为0
            // foreach (KeyValuePair<string, string> kvp in dic)
            //      MessageBox.Show(kvp.Key + " 的物理值为：" + kvp.Value);
            return dic;
        }

        public static Dictionary<string, string> decode(string mid, string data)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            //把十进制转换成16进制

            // MessageBox.Show(database.Count().ToString());
            foreach (Message m in database)
            {
                string temp_id = m.messageId.ToString("x8").TrimStart('0');
                if (temp_id.Length != 3)
                {
                    while (temp_id.Length != 3)
                    {
                        temp_id = "0" + temp_id;
                    }
                }
                if (temp_id == mid)
                {
                    //MessageBox.Show("message id is : " + mid);
                    Signal signal = new Signal();
                    foreach (string str in m.signals)
                    {
                        signal = Signal.getSignal(str);
                        string A = signal.A.ToString();
                        string B = signal.B.ToString();
                        string C = signal.C.ToString();
                        string D = signal.D.ToString();
                        string startBit = signal.startBit.ToString();
                        string len = signal.bitLength.ToString();
                        string qdata = wget(data, startBit, len);
                        //qdata is null
                        // MessageBox.Show("qdata is : "+qdata);
                        float qdata10 = Convert.ToInt32(qdata, 2);
                        float x = qdata10;
                        float phy = float.Parse(A) * x + float.Parse(B);
                        float temp_phy = 0f;
                        if (phy > float.Parse(D))
                        {
                            temp_phy = phy;
                        }
                        else if (phy < float.Parse(C))
                        {
                            temp_phy = phy;
                        }
                        else
                        {
                            temp_phy = phy;
                        }
                        dic.Add(signal.signalName, temp_phy.ToString());
                        //MessageBox.Show(signal.signalName + " 的物理值为： " + phy);
                    }
                }
            }
            return dic;
        }


        public static string wget(string data, string from, string number)
        {
            // MessageBox.Show("data is : " + data + "from and number are : " + from + " " + number);
            int f = int.Parse(from);
            int n = int.Parse(number);
            int t = f / 8;
            string temp = "";
            string[] b = new string[64];
            //给64个位依次赋值
            for (int i = 0; i < 64; i++)
            {
                b[i] = data.Substring(i, 1);
            }
            //
            if (f - (t * 8) + 1 >= n)
            {
                for (int i = f; i > f - n; i--)
                {
                    temp += b[i];
                }
            }
            else if (f - (t * 8) + 1 < n)
            {
                int f_1 = f;
                while (n > 8)
                {
                    for (int i = f_1; i >= t * 8; i--)
                    {
                        temp += b[i];
                    }
                    n -= f_1 - (t * 8) + 1;
                    f_1 = (t + 2) * 8 - 1;
                    t++;
                }
                for (int i = f_1; i > f_1 - n; i--)
                {
                    temp += b[i];
                }
            }
            // MessageBox.Show("temp is : " + temp);
            return temp;
        }

        public static string storage(string data)
        {
            string[] st = new string[8];
            string[] a = new string[64];
            string[] b = new string[64];
            string dis = "";
            //将16进制data转换成2进制数

            string two_data = deal16(data);
            //List<string> list = new List<string>();

            for (int i = 0; i < 64; i++)
            {
                //st[i] = two_data.Substring(i*8,8);
                a[i] = two_data.Substring(i, 1);
            }
            for (int i = 0; i <= 7; i++)
            {
                for (int j = 0; j <= 7; j++)
                {
                    b[i * 8 + 7 - j] = a[i * 8 + j];
                }
            }
            for (int i = 0; i < 64; i++)
            {
                dis += b[i];
            }
            //MessageBox.Show(two_data + "\r\n" +two_data.Length +"\r\n" + dis);
            return dis;
        }

        public static string deal16(string id)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("0", "0000");
            dic.Add("1", "0001");
            dic.Add("2", "0010");
            dic.Add("3", "0011");
            dic.Add("4", "0100");
            dic.Add("5", "0101");
            dic.Add("6", "0110");
            dic.Add("7", "0111");
            dic.Add("8", "1000");
            dic.Add("9", "1001");
            dic.Add("a", "1010");
            dic.Add("b", "1011");
            dic.Add("c", "1100");
            dic.Add("d", "1101");
            dic.Add("e", "1110");
            dic.Add("f", "1111");
            dic.Add("A", "1010");
            dic.Add("B", "1011");
            dic.Add("C", "1100");
            dic.Add("D", "1101");
            dic.Add("E", "1110");
            dic.Add("F", "1111");
            string[] aaa = new string[16];
            string result = "";

            for (int i = 0; i < 16; i++)
            {
                if (dic.ContainsKey(id.Substring(i, 1)))
                {
                    string temp = id.Substring(i, 1);
                    result += dic[temp];
                }
            }

            return result;
        }

        public static string deal2(string id)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("0000", "0");
            dic.Add("0001", "1");
            dic.Add("0010", "2");
            dic.Add("0011", "3");
            dic.Add("0100", "4");
            dic.Add("0101", "5");
            dic.Add("0110", "6");
            dic.Add("0111", "7");
            dic.Add("1000", "8");
            dic.Add("1001", "9");
            dic.Add("1010", "a");
            dic.Add("1011", "b");
            dic.Add("1100", "c");
            dic.Add("1101", "d");
            dic.Add("1110", "e");
            dic.Add("1111", "f");
            //dic.Add("1010", "A");
            //dic.Add("1011", "B");
            // dic.Add("1100", "C");
            //dic.Add("1101", "D");
            //dic.Add("1110", "E");
            // dic.Add("1111", "F");
            string[] aaa = new string[16];
            string result = "";

            for (int i = 0; i < 64; i += 4)
            {
                if (dic.ContainsKey(id.Substring(i, 4)))
                {
                    string temp = id.Substring(i, 4);
                    result += dic[temp];
                }
            }

            return result;
        }
        //设置
        public string Put(string messageid, Dictionary<string, string> dic)
        {
            float x = 0;
            Signal signal = new Signal();
            string[] b = new string[64];
            string templen = "";
            //给64个位依次赋值
            for (int i = 0; i < 64; i++)
            {
                b[i] = "0";
            }
            foreach (Message message in database)
            {
                if (messageid == message.messageId.ToString())
                {
                    //遍历每一个有内容的signal
                    foreach (KeyValuePair<string, string> kv in dic)
                    {
                        foreach (string str in message.signals)
                        {
                            string[] temp = str.Split(' ');
                            if (kv.Key == temp[2])
                            {
                                signal = Signal.getSignal(str);
                                string A = signal.A.ToString();
                                string B = signal.B.ToString();
                                string C = signal.C.ToString();
                                string D = signal.D.ToString();
                                string startBit = signal.startBit.ToString();
                                string len = signal.bitLength.ToString();
                                //已获得当前signal 的全部信息
                               // MessageBox.Show("str is " + str + " A is : " + A);
                                //得到十进制的x
                                x = (float.Parse(kv.Value) - float.Parse(B)) / float.Parse(A);
                                //将十进制的x变成二进制
                                string x2 = Convert.ToString((int)x, 2);
                                if(x2.Length < int.Parse(len))
                                {
                                    while(x2.Length < int.Parse(len))
                                    {
                                        x2 += "0" + x2;
                                    }
                                }
                                //获取要设置几位   此时的signal没有值
                                //string len = signal.bitLength.ToString();
                                string newlen = x2.Substring(0, int.Parse(len));
                                string from = signal.startBit.ToString();
                                //把数据放到数组里

                                for (int i = 0; i < newlen.Length; i++)
                                {
                                    int n = int.Parse(from) / 8;
                                    int t = int.Parse(from) % 8;
                                    b[8 * n + 7 - t] = newlen.Substring(0, 1);
                                    t--;
                                }
                            }
                        }

                    }
                    break;

                }
            }
            for (int i = 0; i < 64; i++)
            {
                templen += b[i];
            }
            string temp16 = deal2(templen);
            //MessageBox.Show("result is : " + templen + " \r\n位数为： " + templen.Length + "\r\n" + temp16 + " \r\n位数为： " + temp16.Length);
            string t_id = int.Parse(messageid).ToString("x8").TrimStart('0');
            if (t_id.Length != 3)
            {
                while (t_id.Length != 3)
                {
                    t_id = "0" + t_id;
                }
            }
            string result = "t" + t_id + "8" + temp16;
           // MessageBox.Show("result is : " + result);
            return result;
        }
    }
}
