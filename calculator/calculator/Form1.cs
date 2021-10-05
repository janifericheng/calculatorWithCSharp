//hand coded by Janifer I Cheng from the "Easy VB.Net, Beginners to Visual Basic App to Windows Forms"
//on Udemy, taught by Musavi Abdullah. Converted into C# format by Janifer Cheng.
//This project is strictly for display use only with the permission of the original author of the code.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.oplabel.Text = "-";
            //=================
            if (this.label1.Text == "")
            { }
            else
            { this.firstNumLab.Text = this.label1.Text; }
            //=================
            this.label1.Text = "";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + "0";
        }

        private void btndot_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + ".";
        }

    public void clearText()
        {
         this.oplabel.Text = "";
         this.firstNumLab.Text = "";
        }
        private void btneq_Click(object sender, EventArgs e)
        {
            double.TryParse(this.firstNumLab.Text, out double fn);
            double.TryParse(this.label1.Text, out double sn);
            double rn;


            //if (this.oplabel.Text == "+")
            //{
            //    rn = fn + sn;
            //    this.label1.Text = rn.ToString();
            //    clearText();
            //}
            //else if (this.oplabel.Text == "-")
            //{
            //    rn = fn - sn;
            //    this.label1.Text = rn.ToString();
            //    clearText();
            //}
            //else if (this.oplabel.Text == "x")
            //{
            //    rn = fn * sn;
            //    this.label1.Text = rn.ToString();
            //    clearText();
            //}
            //else if (this.oplabel.Text == "/")
            //{
            //    rn = fn / sn;
            //    this.label1.Text = rn.ToString();
            //    clearText();
            //}
            //else
            //{ }

            //The above if/else and switch code below provide the same outcome




            switch (oplabel.Text)
            {
                case "+":
                    rn = fn + sn;
                    this.label1.Text = rn.ToString();
                    clearText();
                    break;
                case "-":
                    rn = fn - sn;
                    this.label1.Text = rn.ToString();
                    clearText();
                    break;
                case "/":
                    rn = fn / sn;
                    this.label1.Text = rn.ToString();
                    clearText();
                    break;
                case "x":
                    rn = fn * sn;
                    this.label1.Text = rn.ToString();
                    clearText();
                    break;
            }


        }

        private void btn1_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + "9";
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            this.label1.Text = "";
            //below functions the same as the above code
            //this.label1.ResetText();
        }

        private void btnpls_Click(object sender, EventArgs e)
        {
            this.oplabel.Text = "+";
            //=================
            if (this.label1.Text == "")
            {}
            else
            { this.firstNumLab.Text = this.label1.Text; }
            //=================
            this.label1.Text = "";
        }

        private void btnmult_Click(object sender, EventArgs e)
        {
            this.oplabel.Text = "x";
            //=================
            if (this.label1.Text == "")
            { }
            else
            { this.firstNumLab.Text = this.label1.Text; }
            //=================
            this.label1.Text = "";
        }

        private void btnper_Click(object sender, EventArgs e)
        {
            this.oplabel.Text = "/";
            //=================
            if (this.label1.Text == "")
            { }
            else
            { this.firstNumLab.Text = this.label1.Text; }
            //=================
            this.label1.Text = "";
        }
    }
}
