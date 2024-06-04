using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AuthentificationZI
{
    internal class Guard
    {
        SqlConnection connection;
        public static byte[] key1 = ASCIIEncoding.ASCII.GetBytes("12345678");
        public static byte[] key2 = ASCIIEncoding.ASCII.GetBytes("abcdefgh");
        public Guard()
        {
            string connectionstring = "";
            connection = new SqlConnection(connectionstring);
            connection.Open();
            Console.WriteLine("Connection to database established successfully.");

        }
        public void CreateNewUser(string username, string password)
        {
            
            string salt = Saltmaker();
            password = password + salt;
            string finalpassword = MD5Hash(password);
            password = null;

            try
            {
                // Создаем и выполняем SQL команду
                string query = "INCERT INTO OurUsers(UserLogin, RegDate, Salt, HashSaltedPassword) VALUES (@login, @salt, @finalpass, @regdate)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@login", username);
                    command.Parameters.AddWithValue("@Salt", salt);
                    command.Parameters.AddWithValue("@finalpass", finalpassword);
                    command.Parameters.AddWithValue("@regdate", DateTime.Today);
                }
                MessageBox.Show("New user succesfully added!");
            }
            catch (Exception ex) {  MessageBox.Show(ex.Message); }
        }
        private string Saltmaker()
        {
            const string dasABC = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string pmarks = "!:;'.,?()";
            const string numberlist = "0123456789";
            int chainlen = 8;
            StringBuilder ans = new StringBuilder(chainlen);
            Random rnd = new Random();
            int help;
            //Random help = new Random();
            for (int i = 0; i < chainlen; i++)
            {
                help = rnd.Next(5);
                switch (help)
                {
                    case (4):
                        { ans.Append(pmarks[rnd.Next(pmarks.Length)]); continue; }

                    case (3):
                        { ans.Append(' '); continue; }

                    case (2):
                        { ans.Append(numberlist[rnd.Next(numberlist.Length)]); continue; }

                    case (1):
                        { ans.Append(dasABC[rnd.Next(dasABC.Length)]); continue; }
                }
            }
            return ans.ToString();

        }
        private string MD5Hash(string input)
        {

            byte[] inputBytes = Encoding.UTF8.GetBytes(input);

            using (MD5 md = MD5.Create())
            {
                byte[] hashBytes = md.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("x2"));
                }

                return sb.ToString();

            }
        }
        /*Нить, осуществляющая проверку пароля -- TBD
        public void CheckingThread()
        {
            Console.WriteLine("Guard: Waiting for message from User");
            Program.messageReceived.WaitOne();
            string currentpassword = Des.Decrypt(Des.Decrypt(Program.buff, VerifyingUser.key2), VerifyingUser.key1);
            currentpassword = MD5Hash(currentpassword + salt);
            if (currentpassword.Equals(this.password))
            {
                Console.WriteLine("Authorisation success!");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }*/
    }
}
