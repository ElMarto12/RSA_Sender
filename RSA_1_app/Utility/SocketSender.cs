using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace RSA_1_app.Utility
{
    public static class SocketSender
    {
        public static void Send(string message)
        {
            using (TcpClient client = new TcpClient("localhost", 12345))
            using (NetworkStream stream = client.GetStream())
            {
                byte[] buffer = Encoding.UTF8.GetBytes(message);
                stream.Write(buffer, 0, buffer.Length);
            }
        }
    }
}
