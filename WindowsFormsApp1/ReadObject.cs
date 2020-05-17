using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;

namespace AsyncTcpClient
{
    /// <summary>
    /// 用于保存和接收发送数据需要的参数
    /// </summary>
    class ReadObject
    {
        public NetworkStream netStream;
        public byte[] bytes;
        public ReadObject(NetworkStream netStream, int bufferSize)
        {
            this.netStream = netStream;
            bytes = new byte[bufferSize];
        }
    }
}
