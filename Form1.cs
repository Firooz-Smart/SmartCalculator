using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class SmartCalculator : Form
    {
        int[,] equation = new int[3,4];
        Calc mycalc = new Calc();
        public SmartCalculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           
            Check();
            try
            {
                equation[0, 0] = int.Parse(a00.Text);
                equation[0, 1] = int.Parse(a01.Text);
                equation[0, 2] = int.Parse(a02.Text);
                equation[0, 3] = int.Parse(p1.Text);
                equation[1, 0] = int.Parse(a10.Text);
                equation[1, 1] = int.Parse(a11.Text);
                equation[1, 2] = int.Parse(a12.Text);
                equation[1, 3] = int.Parse(p2.Text);
                equation[2, 0] = int.Parse(a20.Text);
                equation[2, 1] = int.Parse(a21.Text);
                equation[2, 2] = int.Parse(a22.Text);
                equation[2, 3] = int.Parse(p3.Text);
            }
            catch(Exception )
            {
               
                warner.Text = "input is not valid!";
            }
          
            int delta = mycalc.calculatD(equation);
            int deltax = mycalc.calculateDx(equation);
            int deltay = mycalc.calculateDy(equation);
            int deltaz = mycalc.calculateDz(equation);

            if(delta==0)
            {
                dr.Text = "0";
                dx.Text = "";
                dy.Text = "";
                dz.Text = "";
                
            }
            else 
            {
                dr.Text = mycalc.calculatD(equation).ToString();
                dx.Text = mycalc.xfinder(deltax, delta);
                dy.Text = mycalc.yfinder(deltay, delta);
                dz.Text = mycalc.zfinder(deltaz, delta);
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Check()
        {
            if (a00.Text == "")
                a00.Text = "0";
            if (a01.Text == "")
                a01.Text = "0";
            if (a02.Text == "")
                a02.Text = "0";
            if (p1.Text == "")
                p1.Text = "0";

            if (a10.Text == "")
                a10.Text = "0";
            if (a11.Text == "")
                a11.Text = "0";
            if (a12.Text == "")
                a12.Text = "0";
            if (p2.Text == "")
                p2.Text = "0";


            if (a20.Text == "")
                a20.Text = "0";
            if (a21.Text == "")
                a21.Text = "0";
            if (a22.Text == "")
                a22.Text = "0";
            if (p3.Text == "")
                p3.Text = "0";
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void a00_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void a00_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }

        private void SmartCalculator_Enter(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            a00.Text = "";
            a01.Text = "";
            a02.Text = "";
            p1.Text = "";
            a10.Text = "";
            a11.Text = "";
            a12.Text = "";
            p2.Text = "";
            a21.Text = "";
            a20.Text = "";
            a22.Text = "";
            p3.Text = "";
            dr.Text = "";
            dx.Text = "";
            dy.Text = "";
            dz.Text = "";
            warner.Text = "";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            MessageBox.Show("I am Curious of web Application and Android Development ", "Firooz Smart");
        }
    }
    }

