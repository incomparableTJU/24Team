﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace decode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //static Dictionary<string, List<string>> dd = new Dictionary<string, List<string>>();
        static string[] ds = new string[64];
        int N = 64;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void data_TextChanged(object sender, EventArgs e)
        {

        }

        private void convert_Click(object sender, EventArgs e)
        {
            //开始将文件读入到内存
            string[] str1 = File.ReadAllLines(@"G:\candata.dbc");
            for (int i = 0; i < str1.Length; i++)
            {
                data.Text += str1[i] + "\r\n";
            }
            string str2 = data.Text;
            data.Text = "";
            string canmessage = "";
            string mid16 = "";
            List<string> list = null;
            Dictionary<string, List<string>> dd = new Dictionary<string, List<string>>();
            string[] message = str2.Split(new string[] { "\r\n\r\n" }, StringSplitOptions.None);
            //recieve.Text = message.Length.ToString();
            for (int i = 0; i < message.Length; i++)
            {
                list = new List<string>();
                string[] temp = message[i].Split(new string[] { "\r\n" }, StringSplitOptions.None);
                //MessageBox.Show("length is : " + temp.Length);
                //no problem!
                for (int k = 0; k < temp.Length; k++)
                {
                    if (k == 0)
                    {
                        canmessage = temp[k];
                        string[] info = canmessage.Split(new string[] { " " }, StringSplitOptions.None);
                        string mid10 = info[1];
                        mid16 = int.Parse(mid10).ToString("x8");
                    }
                    else
                    {
                        list.Add(temp[k]);
                    }
                }
                dd.Add(mid16.TrimStart('0'), list);
                //MessageBox.Show(dd[mid16.TrimStart('0')].Count().ToString());
            }
            //here problem!!
            //MessageBox.Show("358的signal number is ："+dd["358"].Count().ToString());

            //开始解析
            string str = recieve.Text;
            string tt = "";
            string TT = "";
            string rawdata = "";
            string tran = "";
            if (str.StartsWith("t"))
            {
                tt = str.Substring(1, 3);
                rawdata = str.Substring(5, 16);
                tran = tt;
            } else if (str.StartsWith("T"))
            {
                TT = str.Substring(1, 8);
                rawdata = str.Substring(10, 16);
                tran = TT;
            }
            //将原始数据进行二进制存储，并进行赋值
            string dealdata = storage(rawdata);
            decode(tran,dealdata,dd);
            //测试数据都存入到dd这个dictionary中
            /*
            foreach (string item in dd.Keys)
            {
                 data.Text += item + "\r\n";
                foreach (string t in dd[item]) 
                {
                    data.Text += t + "\r\n";
                }
            }
            */
        }

        //处理描述数据库的数据
        private void decode(string mid, string dealdata, Dictionary<string, List<string>> dd)
        {
            string phy_low = "";
            string phy_high = "";
            string limit_low = "";
            string limit_high = "";
            //MessageBox.Show(mid);
            //mid有值
            //MessageBox.Show(dd[mid].Count().ToString());
            foreach (string str in dd[mid])
            {
                string[] temp = str.Split(new string[] { " " }, StringSplitOptions.None);
                //MessageBox.Show(temp[1] + "," + temp[3]);
                string phyvalue = temp[2];
                string pailie = temp[4];
                string v = temp[5];
                string limit = temp[6];
                string description = temp[7];

                //
                string[] a = pailie.Split(new string[] { "@" }, StringSplitOptions.None);
                string[] b = a[0].Split(new string[] { "|" }, StringSplitOptions.None);
                //!!!
                //MessageBox.Show(a[0]);
                string signalfrom = b[0];
                string signalnum = b[1];
                string method = a[1];

                //
                string[] tempphy = v.Split(new string[] { "," }, StringSplitOptions.None);
                phy_low = tempphy[0].Substring(1, tempphy[0].Length - 1);
                phy_high = tempphy[1].Substring(0, tempphy[1].Length - 1);

                //MessageBox.Show("mid is : " + mid +" limit is :  "+limit);
                string[] tempphy1 = limit.Split(new string[] { "|" }, StringSplitOptions.None);
                if (tempphy1[0] != null && tempphy1[1] != null)
                {
                    limit_low = tempphy1[0].Substring(1, tempphy1[0].Length - 1);
                    limit_high = tempphy1[1].Substring(0, tempphy1[1].Length - 1);
                }
                //取出来的x值
                string qdata = wget(dealdata, signalfrom, signalnum);

                float x = float.Parse(qdata);
                 float phy = float.Parse(phy_low) * x + float.Parse(phy_high);
                MessageBox.Show("物理量为： " + phyvalue + " 物理值为： " + phy.ToString());
            }
        }

        //取数据
        private string wget(string data, string from, string number)
        {
            int f = int.Parse(from);
            int n = int.Parse(number);
            int t = f / 8;
            string temp = "";
            string[] b = new string[64];
            for(int i = 0; i < 64; i++)
            {
                b[i] = data.Substring(i, 1);
            }
            if(f - (t * 8) + 1 >= n)
            {
                for(int i = f; i > f - n; i--)
                {
                    temp += b[i];
                }
            }else if(f - (t * 8) + 1 < n)
            {
                int f_1 = f;
                while(n > 8)
                {
                      for(int i = f_1; i >= t * 8; i--)
                     {
                        temp += b[i];
                     }
                    n -= f_1 - (t * 8) + 1;
                    f_1 = (t + 2) * 8 - 1;
                    t++;
                }
               for(int i = f_1; i > f_1 - n; i--)
                {
                    temp += b[i];
                }
            }
            return temp;
        }


        //存数据
        private string storage(string data)
        {
            string[] st = new string[8];
            string[] a = new string[64];
            string[] b = new string[64];
            string dis = "";
            //将16进制data转换成2进制数
            
            string two_data = deal16(data);
            //List<string> list = new List<string>();
            
            for(int i = 0; i < 64; i++)
            {
                //st[i] = two_data.Substring(i*8,8);
                a[i] = two_data.Substring(i, 1);
            }
            for(int i = 0; i <= 7; i++)
            {
                for(int j = 0; j <= 7; j++)
                {
                    b[i * 8 + 7 - j] = a[i * 8 + j];
                }
            }
            for(int i = 0; i < 64; i++)
            {
                dis += b[i];
            }
            //MessageBox.Show(two_data + "\r\n" +two_data.Length +"\r\n" + dis);
            return dis;
        }
        private string stringreverse(string str)
        {
            string temp = "";
            for (int i = str.Length - 1; i >= 0; i--)
                temp += str.Substring(i, 1);
            return temp;
        }
        private string deal16(string data)
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

            for(int i = 0; i < 16; i++)
            {
                if (dic.ContainsKey(data.Substring(i, 1)))
                {
                    string temp = data.Substring(i, 1);
                    result += dic[temp];
                }
            }

            return result;
        }
        
        private void display()
        {
            
        }

        }
}
