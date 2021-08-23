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
    public partial class Coffee : Form
    {
        public Coffee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\My Pro\cafedb.mdb");
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Coffee values('" + textBox1.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "','" + textBox2.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record inserted Sucessfully");


        }



        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void comboBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }



        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {

            if (comboBox1.SelectedItem.ToString() == "Latte")
            {
                if (comboBox2.SelectedItem.ToString() == "Hot")
                {
                    textBox2.Text = (float.Parse(comboBox3.Text) * 50).ToString();
                }
                if (comboBox2.SelectedItem.ToString() == "Cold")
                {
                    textBox2.Text = (float.Parse(comboBox3.Text) * 35).ToString();
                }
                if (comboBox2.SelectedItem.ToString() == "Normal")
                {
                    textBox2.Text = (float.Parse(comboBox3.Text) * 45).ToString();
                }

            }
            else if (comboBox1.SelectedItem.ToString() == "Cappuccino")
            {
                if (comboBox2.SelectedItem.ToString() == "Hot")
                {
                    textBox2.Text = (float.Parse(comboBox3.Text) * 80).ToString();
                }
                if (comboBox2.SelectedItem.ToString() == "Cold")
                {
                    textBox2.Text = (float.Parse(comboBox3.Text) * 70).ToString();
                }
                if (comboBox2.SelectedItem.ToString() == "Normal")
                {
                    textBox2.Text = (float.Parse(comboBox3.Text) * 75).ToString();
                }

            }
            else if (comboBox1.SelectedItem.ToString() == "Flat White")
            {
                if (comboBox2.SelectedItem.ToString() == "Hot")
                {
                    textBox2.Text = (float.Parse(comboBox3.Text) * 120).ToString();
                }
                if (comboBox2.SelectedItem.ToString() == "Cold")
                {
                    textBox2.Text = (float.Parse(comboBox3.Text) * 80).ToString();
                }
                if (comboBox2.SelectedItem.ToString() == "Normal")
                {
                    textBox2.Text = (float.Parse(comboBox3.Text) * 100).ToString();
                }

                else if (comboBox1.SelectedItem.ToString() == "Long Blak")
                {
                    if (comboBox2.SelectedItem.ToString() == "Hot")
                    {
                        textBox2.Text = (float.Parse(comboBox3.Text) * 140).ToString();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Cold")
                    {
                        textBox2.Text = (float.Parse(comboBox3.Text) * 120).ToString();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Normal")
                    {
                        textBox2.Text = (float.Parse(comboBox3.Text) * 130).ToString();
                    }
                }

                textBox1.Text = " ";
                comboBox1.Text = " ";
                comboBox2.Text = " ";
                comboBox3.Text = " ";
                textBox2.Text = " ";

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