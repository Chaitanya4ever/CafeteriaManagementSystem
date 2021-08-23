using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Project
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void coustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer obj = new Customer();
            obj.ShowDialog();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee obj = new Employee();
            obj.ShowDialog();
        }

        
        private void coffeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Coffee obj = new Coffee();
            obj.ShowDialog();
        }

        private void comboPackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Combo_Pack obj = new Combo_Pack();
            obj.ShowDialog();
        }

        private void pizzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pizza obj = new Pizza();
            obj.ShowDialog();
        }

        private void productDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductDetails obj = new ProductDetails();
            obj.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
            this.Close();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void customerReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customerrpt c1 = new Customerrpt();
            c1.Show();
        }

        private void emmployeeReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employeerpt c2 = new Employeerpt();
            c2.Show(); 
        }

        private void productReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductReport c3 = new ProductReport();
            c3.Show();
        }

        private void changePasswordToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ChangePass obj = new ChangePass();
            obj.ShowDialog();
        }

        private void coffeeReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Coffeerpt obj = new Coffeerpt();
            obj.Show();
        }

        private void pizzaReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pizzarpt obj = new Pizzarpt();
            obj.Show();
        }

        private void comboPackReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ComboPackrpt obj = new ComboPackrpt();
            obj.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void billToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

 
    }
}
