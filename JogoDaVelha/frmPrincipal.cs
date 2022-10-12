using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaVelha
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private Boolean Turno = true;

        private string verificador()
        {
            if ((btn1x1.Text == btn2x1.Text) && (btn2x1.Text == btn3x1.Text) || (btn1x1.Text == btn1x2.Text) && (btn1x2.Text == btn1x3.Text))
            {
                label1.Text = "Aloo";
            }
            else if ((btn2x2.Text == btn2x1.Text) && (btn2x1.Text == btn2x3.Text) || (btn2x2.Text == btn1x2.Text) && (btn1x2.Text == btn3x2.Text) || (btn2x2.Text == btn1x1.Text) && (btn1x1.Text == btn3x3.Text) || (btn2x2.Text == btn1x3.Text) && (btn1x3.Text == btn3x1.Text))
            {
                label1.Text = "Aloo";
            }
            else if ((btn3x3.Text == btn2x3.Text) && (btn2x3.Text == btn1x3.Text) || (btn3x3.Text == btn3x2.Text) && (btn3x2.Text == btn3x1.Text))
            {
                label1.Text = "Aloo";
            }
            else
            {
                label1.Text = "izi";
            }

            return "";
        }

        private void btn1x1_Click(object sender, EventArgs e)
        {

            if (Turno == true)
            {
                btn1x1.Text = "X";
                Turno = false;
            }
            else
            {
                btn1x1.Text = "O";
                Turno = true;
            }

            verificador();
        }

        private void btn1x2_Click(object sender, EventArgs e)
        {
            if (btn1x2.Text == "O")
            {
                btn1x2.Text = "X";
            }
            else
            {
                btn1x2.Text = "O";
            }
            verificador();
        }

        private void btn1x3_Click(object sender, EventArgs e)
        {
            if (btn1x3.Text == "O")
            {
                btn1x3.Text = "X";
            }
            else
            {
                btn1x3.Text = "O";
            }
            verificador();
        }

        private void btn2x1_Click(object sender, EventArgs e)
        {
            if (btn2x1.Text == "O")
            {
                btn2x1.Text = "X";
            }
            else
            {
                btn2x1.Text = "O";
            }
            verificador();
        }

        private void btn2x2_Click(object sender, EventArgs e)
        {
            if (btn2x2.Text == "O")
            {
                btn2x2.Text = "X";
            }
            else
            {
                btn2x2.Text = "O";
            }
            verificador();
        }

        private void btn2x3_Click(object sender, EventArgs e)
        {
            if (btn2x3.Text == "O")
            {
                btn2x3.Text = "X";
            }
            else
            {
                btn2x3.Text = "O";
            }
            verificador();
        }

        private void btn3x1_Click(object sender, EventArgs e)
        {
            if (btn3x1.Text == "O")
            {
                btn3x1.Text = "X";
            }
            else
            {
                btn3x1.Text = "O";
            }
            verificador();
        }

        private void btn3x2_Click(object sender, EventArgs e)
        {
            if (btn3x2.Text == "O")
            {
                btn3x2.Text = "X";
            }
            else
            {
                btn3x2.Text = "O";
            }
            verificador();
        }

        private void btn3x3_Click(object sender, EventArgs e)
        {
            if (btn3x3.Text == "O")
            {
                btn3x3.Text = "X";
            }
            else
            {
                btn3x3.Text = "O";
            }
            verificador();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
