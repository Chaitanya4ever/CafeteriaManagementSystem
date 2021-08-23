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
    public partial class Pizza : Form
    {
        public Pizza()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\My Pro\cafedb.mdb");
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Pizza values('" + textBox1.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "','" + textBox2.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record inserted Sucessfully");

        
            textBox1.Text = " ";
            comboBox1.Text = " ";
            comboBox2.Text = " ";
            comboBox3.Text = " ";
            textBox2.Text = " ";
            }
        

       

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Marinara")
            {
                if (comboBox2.SelectedItem.ToString() == "Veg")
                {
                    textBox2.Text = (float.Parse(comboBox3.Text) * 250).ToString();
                }
                if (comboBox2.SelectedItem.ToString() == "Non-Veg")
                {
                    textBox2.Text = (float.Parse(comboBox3.Text) * 235).ToString();
                }
            }
            else if (comboBox1.SelectedItem.ToString() == "Margherita")
            {
                if (comboBox2.SelectedItem.ToString() == "Veg")
                {
                    textBox2.Text = (float.Parse(comboBox3.Text) * 240).ToString();
                }
                if (comboBox2.SelectedItem.ToString() == "Non-Veg")
                {
                    textBox2.Text = (float.Parse(comboBox3.Text) * 220).ToString();
                }
            }
            else if (comboBox1.SelectedItem.ToString() == "Seafood")
            {
                if (comboBox2.SelectedItem.ToString() == "Veg")
                {
                    textBox2.Text = (float.Parse(comboBox3.Text) * 180).ToString();
                }
                if (comboBox2.SelectedItem.ToString() == "Non-Veg")
                {
                    textBox2.Text = (float.Parse(comboBox3.Text) * 150).ToString();
                }
            }

            else if (comboBox1.SelectedItem.ToString() == "Neapolitan")
            {
                if (comboBox2.SelectedItem.ToString() == "Veg")
                {
                    textBox2.Text = (float.Parse(comboBox3.Text) * 290).ToString();
                }
                if (comboBox2.SelectedItem.ToString() == "Non-Veg")
                {
                    textBox2.Text = (float.Parse(comboBox3.Text) * 280).ToString();
                }
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
