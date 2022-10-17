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
            pictureBox1.Controls.Add(pictureBox2);
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Visible = false;
        }


        private bool Turno = true;
        private int Contador = 0;


        private string verificador()
        {
            if ((btn1x1.Text == btn2x1.Text) && (btn2x1.Text == btn3x1.Text) && (btn1x1.Text != "") || (btn1x1.Text == btn1x2.Text) && (btn1x2.Text == btn1x3.Text) && (btn1x1.Text != ""))
            {
                // O verificador ocorre com base na última jogada, pois ela quem define o vencedor.
                // Se for Verdadeiro, e quem jogar X, o Turno passará a ser Falso, mas X ganha.
                // Se for Falso, e quem jogar O, o Turno passará a ser Verdadeiro, mas O ganha.
                label1.Text = (Turno) ? "O VENCEU." : "X VENCEU.";
            }
            else if ((btn2x2.Text == btn2x1.Text) && (btn2x1.Text == btn2x3.Text) && (btn2x2.Text != "") || (btn2x2.Text == btn1x2.Text) && (btn1x2.Text == btn3x2.Text) && (btn2x2.Text != "") || (btn2x2.Text == btn1x1.Text) && (btn1x1.Text == btn3x3.Text) && (btn2x2.Text != "") || (btn2x2.Text == btn1x3.Text) && (btn1x3.Text == btn3x1.Text) && (btn2x2.Text != ""))
            {
                label1.Text = (Turno) ? "O VENCEU." : "X VENCEU.";
            }
            else if ((btn3x3.Text == btn2x3.Text) && (btn2x3.Text == btn1x3.Text) && (btn3x3.Text != "") || (btn3x3.Text == btn3x2.Text) && (btn3x2.Text == btn3x1.Text) && (btn3x3.Text != ""))
            {
                label1.Text = (Turno) ? "O VENCEU." : "X VENCEU.";
            }
            else if (Contador == 9)
            {
                // Se houverem se passado 9 turnos, ou seja, 9 quadrados preenchidos, não mais possibilidade de vitória.
                label1.Text = "VELHA!!!";
                pictureBox2.BackColor = Color.Transparent;
                pictureBox2.Visible = true;
            }
            else
            {
                label1.Text = "EM JOGO";
            }

            return "";
        }

        private void btn1x1_Click(object sender, EventArgs e)
        {
            if (btn1x1.Text == "")
            {
                if (Turno == true)
                {
                    btn1x1.Text = "X";
                    Turno = false;
                    Contador++;
                    lblContador.Text = Convert.ToString(Contador);
                }
                else
                {
                    btn1x1.Text = "O";
                    Turno = true;
                    Contador++;
                    lblContador.Text = Convert.ToString(Contador);
                }
            }
            else
            {

            }

            verificador();
        }

        private void btn1x2_Click(object sender, EventArgs e)
        {
            if (btn1x2.Text == "")
            {
                if (Turno == true)
                {
                    btn1x2.Text = "X";
                    Turno = false;
                    Contador++;
                    lblContador.Text = Convert.ToString(Contador);
                }
                else
                {
                    btn1x2.Text = "O";
                    Turno = true;
                    Contador++;
                    lblContador.Text = Convert.ToString(Contador);
                }
            }

            verificador();
        }

        private void btn1x3_Click(object sender, EventArgs e)
        {
            if (btn1x3.Text == "")
            {
                if (Turno == true)
                {
                    btn1x3.Text = "X";
                    Turno = false;
                    Contador++;
                    lblContador.Text = Convert.ToString(Contador);
                }
                else
                {
                    btn1x3.Text = "O";
                    Turno = true;
                    Contador++;
                    lblContador.Text = Convert.ToString(Contador);
                }
            }
            verificador();
        }

        private void btn2x1_Click(object sender, EventArgs e)
        {
            if (btn2x1.Text == "")
            {
                if (Turno == true)
                {
                    btn2x1.Text = "X";
                    Turno = false;
                    Contador++;
                    lblContador.Text = Convert.ToString(Contador);
                }
                else
                {
                    btn2x1.Text = "O";
                    Turno = true;
                    Contador++;
                    lblContador.Text = Convert.ToString(Contador);
                }
            }
            verificador();
        }

        private void btn2x2_Click(object sender, EventArgs e)
        {
            if (btn2x2.Text == "")
            {
                if (Turno == true)
                {
                    btn2x2.Text = "X";
                    Turno = false;
                    Contador++;
                    lblContador.Text = Convert.ToString(Contador);
                }
                else
                {
                    btn2x2.Text = "O";
                    Turno = true;
                    Contador++;
                    lblContador.Text = Convert.ToString(Contador);
                }
            }
            verificador();
        }

        private void btn2x3_Click(object sender, EventArgs e)
        {
            if (btn2x3.Text == "")
            {
                if (Turno == true)
                {
                    btn2x3.Text = "X";
                    Turno = false;
                    Contador++;
                    lblContador.Text = Convert.ToString(Contador);
                }
                else
                {
                    btn2x3.Text = "O";
                    Turno = true;
                    Contador++;
                    lblContador.Text = Convert.ToString(Contador);
                }
            }
            verificador();

        }

        private void btn3x1_Click(object sender, EventArgs e)
        {
            if (btn3x1.Text == "")
            {
                if (Turno == true)
                {
                    btn3x1.Text = "X";
                    Turno = false;
                    Contador++;
                    lblContador.Text = Convert.ToString(Contador);
                }
                else
                {
                    btn3x1.Text = "O";
                    Turno = true;
                    Contador++;
                    lblContador.Text = Convert.ToString(Contador);
                }
            }
            verificador();
        }

        private void btn3x2_Click(object sender, EventArgs e)
        {
            if (btn3x2.Text == "")
            {
                if (Turno == true)
                {
                    btn3x2.Text = "X";
                    Turno = false;
                    Contador++;
                    lblContador.Text = Convert.ToString(Contador);
                }
                else
                {
                    btn3x2.Text = "O";
                    Turno = true;
                    Contador++;
                    lblContador.Text = Convert.ToString(Contador);
                }
            }
            verificador();
        }

        private void btn3x3_Click(object sender, EventArgs e)
        {
            if (btn3x3.Text == "")
            {
                if (Turno == true)
                {
                    btn3x3.Text = "X";
                    Turno = false;
                    Contador++;
                    lblContador.Text = Convert.ToString(Contador);
                }
                else
                {
                    btn3x3.Text = "O";
                    Turno = true;
                    Contador++;
                    lblContador.Text = Convert.ToString(Contador);
                }
            }
            verificador();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblContador_Click(object sender, EventArgs e)
        {

        }

        private void lblReset_Click(object sender, EventArgs e)
        {
            btn1x1.Text = "";
            btn1x2.Text = "";
            btn1x3.Text = "";
            btn2x1.Text = "";
            btn2x2.Text = "";
            btn2x3.Text = "";
            btn3x1.Text = "";
            btn3x2.Text = "";
            btn3x3.Text = "";
            Contador = 0;
            pictureBox2.BackColor = Color.Transparent;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {


        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cont1, cont2;
            Random rd = new Random();

            // For Loop para renomear.
            for (cont1 = 1; cont1 <= 3; cont1++)
            {
                for (cont2 = 1; cont2 <= 3; cont2++)
                {
                    string randomb = "btn" + Convert.ToString(cont1) + "x" + Convert.ToString(cont2);
                    Button btn = this.Controls.Find(randomb, false).FirstOrDefault() as Button;


                    //inicia um objeto random
                    int randomButton = rd.Next(0, 2); // da o valor de 1 a 9 para uma int usando o objeto random
                    if (randomButton == 1)
                    {
                        btn.Text = "X";
                        Contador++;
                    }
                    else
                    {
                        btn.Text = "O";
                        Contador++;
                    }
                }
            }

        }
    }
}
