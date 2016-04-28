using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Ticketing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLi_Click(object sender, EventArgs e)
        {
            string[] checkpass = { "Admin","User","Engineer" };
            string[] checkusername= { "Admin", "User", "Engineer" };
            bool temp = true;
            for (int i = 0; i < 3; i++)
            {

                bool result = checkpass[i].Equals(tbpass.Text, StringComparison.Ordinal);
                bool result1 = checkusername[i].Equals(tbuser.Text, StringComparison.Ordinal);
                
                
                if (result == true & result1 == true)
                {
                    MessageBox.Show("" + i);
                    temp = true;
                    break;

                }
                else
                {
                    temp = false;
                }
                
             
                

            }
            if (temp == false)
            {

                MessageBox.Show("Invalid Username or Password");
                tbpass.Clear();
                tbuser.Clear();

            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbpass.Clear();
            tbuser.Clear();
        }
    }
}
