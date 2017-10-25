using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantool
{
    /// <summary>
    /// Message_DataBase类，为了获取所有message信息
    /// </summary>
    public static class Message_DataBase
    {
        static List<Message> list;
        static String current_data;//当前最新的未解析的message
        /// <summary>
        /// 得到数据库中所有message
        /// </summary>
        /// <returns></returns>
        public static List<Message> get_all_Message()
        {
            return list;
        }

        /// <summary>
        /// 设置message list
        /// </summary>
        /// <param name="list"></param>
        public static void set_Message(List<Message> l)
        {
            list = l;
        }


        /// <summary>
        /// 获取当前最新的未解析message
        /// </summary>
        /// <param name="data"></param>
        public static void set_current_data(String data)
        {
            current_data = data;
        }

        /// <summary>
        /// 设置当前最新的未解析message
        /// </summary>
        /// <returns></returns>
        public static String get_current_data()
        {
            return current_data;
        }

        public static void get_all_signal()
        {

        }


    }
}
