using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
      

        public Form1()
        {
            InitializeComponent();
            
            
        }
        public bool kemm(int x)
        {
            if (x == 1) return true;
            if (x % 2 == 0) return kemm(x / 2);
            if (x % 3 == 0) return kemm(x / 3);
            if (x % 5 == 0) return kemm(x / 5);
            return false;
        }
        public int kemming(int x)
        {
            if (x == 1) return 1;
            if (kemm(x)) { label1.Text += x + ","; }
            kemming(x - 1);

            return 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int x = Convert.ToInt32(textBox1.Text);
            kemming(x);
            Console.ReadLine();



        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "al gırdın gırdın";
        }
    }




    }


    

