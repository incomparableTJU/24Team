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
        public int messageId { get; set; }
        public string messageName { get; set; }
        public int DLC { get; set; }
        public string nodeNameECU { get; set; }
        public string[] signals { get; set; }

        public Message()
        {
            messageId = 0;
            messageName = null;
            DLC = 8;
            nodeNameECU = null;
            signals = null;

        }

        //将string解析到类Message中
        public Message getMessage(string line)
        {
            //Message m = new Message();
            string[] temp = line.Split(' ');
            this.messageId = int.Parse(temp[1]);
            //Because have a ':' in the end  
            this.messageName = temp[2].Substring(0, temp[2].Length - 1);
            this.DLC = int.Parse(temp[3]);
            this.nodeNameECU = temp[4];
            return this;
        }

        //根据id找到该id对应的signal数组或者列表   最好能用list
        public List<string> findSignal(string id)
        {
            return new List<string>();
        }


        public string toString()
        {
            string content = " MessageId:" + this.messageId + " MessageName:" + this.messageName + " DLC:" + this.DLC+ " MessagFromECU:" + this.nodeNameECU + "\n";
            for (int i = 0; i < this.signals.Length; i++)
            {

                content += signals[i] + "\n";
            }
            return content;
        }

    }
}
