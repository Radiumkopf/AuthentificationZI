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
            if (!textBoxP1.Text.Equals(textBoxP2.Text))
            {
                differentpasslabel.Visible = true;
                return;
            }
            
        }
    }
}
