using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JogoDaVelha_1CD_v_0_1
{
    public partial class Form1 : Form
    {
        String tipo = "X"; //PODE SER X OU 0
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = tipo;
            if (tipo == "X")
                tipo = "0";
            else
                tipo = "X";

            gameOver();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = tipo;
            if (tipo == "X")
                tipo = "0";
            else
                tipo = "X";

            gameOver();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = tipo;
            if (tipo == "X")
                tipo = "0";
            else
                tipo = "X";

            gameOver();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = tipo;
            if (tipo == "X")
                tipo = "0";
            else
                tipo = "X";

            gameOver();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = tipo;
            if (tipo == "X")
                tipo = "0";
            else
                tipo = "X";

            gameOver();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = tipo;
            if (tipo == "X")
                tipo = "0";
            else
                tipo = "X";

            gameOver();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Text = tipo;
            if (tipo == "X")
                tipo = "0";
            else
                tipo = "X";

            gameOver();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Text = tipo;
            if (tipo == "X")
                tipo = "0";
            else
                tipo = "X";

            gameOver();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = tipo;
            if (tipo == "X")
                tipo = "0";
            else
                tipo = "X";

            gameOver();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
        }

        //BOTÃO JOGAR
        private void button10_Click(object sender, EventArgs e)
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            //LIGAR NOVAMENTE OS BOTÕES
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
        }


        //MÉTODO
        void desligarBotoes()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }

        void gameOver()
        {
            //VERIFICAR A VITÓRIA DO X NAS LINHAS
            if (button1.Text == "X" & button2.Text == "X" & button1.Text == "X")
            {
                MessageBox.Show("X ganhou a partida!");
                desligarBotoes();
            }
            if (button4.Text == "X" & button5.Text == "X" & button6.Text == "X")
            {
                MessageBox.Show("X ganhou a partida!");
                desligarBotoes();
            }
            if (button7.Text == "X" & button8.Text == "X" & button9.Text == "X")
            {
                MessageBox.Show("X ganhou a partida!");
                desligarBotoes();
            }

            //VERIFICAR A VITÓRIA DO X NAS COLUNAS
            if (button1.Text == "X" & button6.Text == "X" & button9.Text == "X")
            {
                MessageBox.Show("X ganhou a partida!");
                desligarBotoes();
            }
            if (button2.Text == "X" & button5.Text == "X" & button8.Text == "X")
            {
                MessageBox.Show("X ganhou a partida!");
                desligarBotoes();
            }
            if (button7.Text == "X" & button4.Text == "X" & button3.Text == "X")
            {
                MessageBox.Show("X ganhou a partida!");
                desligarBotoes();
            }

            //VERIFICAR A VITÓRIA DO X NAS DIAGONAIS
            if (button1.Text == "X" & button5.Text == "X" & button7.Text == "X")
            {
                MessageBox.Show("X ganhou a partida!");
                desligarBotoes();
            }
            if (button3.Text == "X" & button5.Text == "X" & button9.Text == "X")
            {
                MessageBox.Show("X ganhou a partida!");
                desligarBotoes();
            }


            //VERIFICAR A VITÓRIA DO 0 NAS LINHAS
            if (button1.Text == "0" & button2.Text == "0" & button1.Text == "0")
            {
                MessageBox.Show("0 ganhou a partida!");
                desligarBotoes();
            }
            if (button4.Text == "0" & button5.Text == "0" & button6.Text == "0")
            {
                MessageBox.Show("0 ganhou a partida!");
                desligarBotoes();
            }
            if (button7.Text == "0" & button8.Text == "0" & button9.Text == "0")
            {
                MessageBox.Show("0 ganhou a partida!");
                desligarBotoes();
            }

            //VERIFICAR A VITÓRIA DO 0 NAS COLUNAS
            if (button1.Text == "0" & button6.Text == "0" & button9.Text == "0")
            {
                MessageBox.Show("0 ganhou a partida!");
                desligarBotoes();
            }
            if (button2.Text == "0" & button5.Text == "0" & button8.Text == "0")
            {
                MessageBox.Show("0 ganhou a partida!");
                desligarBotoes();
            }
            if (button7.Text == "0" & button4.Text == "0" & button3.Text == "0")
            {
                MessageBox.Show("0 ganhou a partida!");
                desligarBotoes();
            }

            //VERIFICAR A VITÓRIA DO 0 NAS DIAGONAIS
            if (button1.Text == "0" & button5.Text == "0" & button7.Text == "0")
            {
                MessageBox.Show("0 ganhou a partida!");
                desligarBotoes();
            }
            if (button3.Text == "0" & button5.Text == "0" & button9.Text == "0")
            {
                MessageBox.Show("0 ganhou a partida!");
                desligarBotoes();
            }
        }
    }
}
