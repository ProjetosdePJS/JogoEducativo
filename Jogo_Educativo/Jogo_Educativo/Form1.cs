using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Jogo_Educativo
{

    public partial class Form1 : Form
    {
        public int A = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.CornflowerBlue; // ao mudar a imagem mudara a cor de fundo para a original
            pictureBox1.Image = Properties.Resources.cachorro; // chama a imagem na tela
            A = 1; // usa - se aqui um verificador com nome A para verificar qual botão foi clicado
        }


        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.CornflowerBlue;
            pictureBox1.Image = Properties.Resources.urso;
            A = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.CornflowerBlue;
            pictureBox1.Image = Properties.Resources.leao;
            A = 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.CornflowerBlue;
            pictureBox1.Image = Properties.Resources.aguia;
            A = 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (A == 1 && textBox1.Text == "CACHORRO")
            {
                pictureBox1.BackColor = Color.Green;
            }
            else
            if (A == 2 && textBox1.Text == "URSO")
            {
                pictureBox1.BackColor = Color.Green;
            }
            else
            if (A == 3 && textBox1.Text == "LEAO")
            {
                pictureBox1.BackColor = Color.Green;
            }
            else
            if (A == 4 && textBox1.Text == "AGUIA")
            {
                pictureBox1.BackColor = Color.Green;
            }
            else
            {
                pictureBox1.BackColor = Color.Red;
            }

            textBox1.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

       
    }
}
