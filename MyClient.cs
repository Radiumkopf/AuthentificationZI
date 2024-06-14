using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AuthentificationZI
{
    internal class MyClient
    {
        public static byte[] key1 = ASCIIEncoding.ASCII.GetBytes("12345678");
        public static byte[] key2 = ASCIIEncoding.ASCII.GetBytes("abcdefgh");
        public async void Start(string username, string password)
        {

            StringBuilder buildmessage = new StringBuilder();
            buildmessage.Append('0');                   //код операции
            buildmessage.Append(username);              //логин
            buildmessage.Append(' ');                   //разделитель
            password = Des.Encrypt(Des.Encrypt(password, key1), key2);
            buildmessage.Append(password);              //зашифрованный пароль    
            buildmessage.Append("<|EOM|>");
            //IPEndPoint ipEndPoint = new IPEndPoint("127.0.0.1", 11_000);
            Socket client = new Socket(
            AddressFamily.InterNetwork,
            SocketType.Stream,
            ProtocolType.Tcp);
            while (true)
            {
                await client.ConnectAsync("127.0.0.1", 8888);
                var message = buildmessage.ToString();
                ArraySegment<byte> messageBytes = new ArraySegment<byte>(Encoding.UTF8.GetBytes(message));
                _ = await client.SendAsync(messageBytes, SocketFlags.None);

                ArraySegment<byte> buffer = new ArraySegment<byte>(new byte[1024]);
                var received = await client.ReceiveAsync(buffer, SocketFlags.None);
                var response = Encoding.UTF8.GetString(buffer.ToArray(), 0, received);
                if (response == "<|ACK|>")
                {
                    break;
                }
            }
            client.Shutdown(SocketShutdown.Both);
        }
    }
}
