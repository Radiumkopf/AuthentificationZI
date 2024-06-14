using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuthentificationZI
{
    public partial class CreateForm : Form
    {
        public CreateForm()
        {
            InitializeComponent();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void buttondone_Click(object sender, EventArgs e)
        {
            differentpasslabel.Visible = false;
            if(String.IsNullOrEmpty(textBoxLogin.Text) && String.IsNullOrEmpty(textBoxP1.Text)&&String.IsNullOrEmpty(textBoxP2.Text)) 
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }
            if(textBoxP1.Text.Contains(' '))
            {
                MessageBox.Show("Пароль не может содержать пробелов!");
                textBoxP1.Clear();
                textBoxP2.Clear();  
                return;
            }
            if (!textBoxP1.Text.Equals(textBoxP2.Text))
            {
                differentpasslabel.Visible = true;
                return;
            }
            MyClient client = new MyClient();
            client.Start(textBoxLogin.Text, textBoxP1.Text);
            this.Close();
        }

        private void buttonShowPass_Click(object sender, EventArgs e)
        {
            if (textBoxP1.PasswordChar == '*')
            {
                textBoxP1.PasswordChar = '\0';
                textBoxP2.PasswordChar = '\0';
            }
            else { 
                textBoxP1.PasswordChar = '*'; 
                textBoxP2.PasswordChar = '*'; 
            }
        }
    }
}
