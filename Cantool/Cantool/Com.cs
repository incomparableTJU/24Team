using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantool
{
    public static class Com
    {
        /// <summary>
        /// 创建私有串口资源
        /// </summary>
        private static SerialPort comDevice = new SerialPort();
        //public void set_com(SerialPort comDevice)
        //{
        //    this.comDevice = comDevice;
        //}
        public static SerialPort get_com()
        {
            return comDevice;
        }
    }
}
