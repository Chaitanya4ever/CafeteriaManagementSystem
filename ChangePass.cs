using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace My_Project
{
    public partial class ChangePass : Form
    {
        public ChangePass()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\My Pro\cafedb.mdb");
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from LogIn where UserName='" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();

            if (textBox3.Text == textBox4.Text)
            {
                con.Open();
                OleDbCommand cm = con.CreateCommand();
                cm.CommandType = CommandType.Text;
                cm.CommandText = "insert into LogIn values('" + textBox1.Text + "','" + textBox4.Text + "')";
                cm.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Password Change sucessfully");

            }
            else
            {
                MessageBox.Show("Password Doesn't change properly.");
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

    }
}
