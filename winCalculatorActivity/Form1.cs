using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winCalculatorActivity
{
    public partial class Form1 : Form
    {
        int val1 = 0;
        string opt;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            txtResutBox.Text = txtResutBox.Text + "1";
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            txtResutBox.Text = txtResutBox.Text + "2";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            val1 = Convert.ToInt32(txtResutBox.Text);
            txtResutBox.Text = "";
            opt = "+";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            int val2 = Convert.ToInt32(txtResutBox.Text);

            if(opt=="+")
                txtResutBox.Text = (val1 + val2).ToString();
            else if(opt=="-")
                txtResutBox.Text = (val1 - val2).ToString();
            else if (opt == "*")
                txtResutBox.Text = (val1 * val2).ToString();
            else if (opt == "/")
                txtResutBox.Text = (val1 / val2).ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            val1 = Convert.ToInt32(txtResutBox.Text);
            txtResutBox.Text = "";
            opt = "-";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtResutBox.Text = txtResutBox.Text + "8";
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            txtResutBox.Text = txtResutBox.Text + "3";
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            txtResutBox.Text = txtResutBox.Text + "4";
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            txtResutBox.Text = txtResutBox.Text + "5";
        }

        private void btnsix_Click(object sender, EventArgs e)
        {
            txtResutBox.Text = txtResutBox.Text + "6";
        }

        private void btnseven_Click(object sender, EventArgs e)
        {
            txtResutBox.Text = txtResutBox.Text + "7";
        }

        private void btnnine_Click(object sender, EventArgs e)
        {
            txtResutBox.Text = txtResutBox.Text + "9";
        }

        private void btnzero_Click(object sender, EventArgs e)
        {
            txtResutBox.Text = txtResutBox.Text + "0";
        }

        private void btnmultiply_Click(object sender, EventArgs e)
        {
            val1 = Convert.ToInt32(txtResutBox.Text);
            txtResutBox.Text = "";
            opt = "*";
        }

        private void btndivide_Click(object sender, EventArgs e)
        {
            val1 = Convert.ToInt32(txtResutBox.Text);
            txtResutBox.Text = "";
            opt = "/";
        }
    }
}
