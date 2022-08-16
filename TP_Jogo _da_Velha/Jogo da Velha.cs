using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Jogo__da_Velha
{
    public partial class Jogo_da_Velha : Form
    {
        string[,] tabuleiro = new string[3,3];
        string jogador1 = "X";
        string jogador2 = "O";
        int contador = 0;
        


        public Jogo_da_Velha()
        {
            InitializeComponent();
        }

        private void Jogo_da_Velha_Load(object sender, EventArgs e)
        {

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (contador % 2 == 0)
            {
                if (tabuleiro[0, 0] == null)
                {
                    tabuleiro[0, 0] = jogador1;
                    btn1.Text = jogador1;
                    contador++;
                    terminar_jogo();
                }
                else
                {
                    MessageBox.Show("Posição ocupada");
                }
            }
            else
            {
                
                if (tabuleiro[0, 0] == null)
                {
                    tabuleiro[0, 0] = jogador2;
                    btn1.Text = jogador2;
                    contador++;
                    terminar_jogo();
                }
                else
                {
                    MessageBox.Show("Posição ocupada");
                }
            }
           
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            if (contador % 2 == 0)
            {
                if (tabuleiro[0, 1] == null)
                {
                    tabuleiro[0, 1] = jogador1;
                    btn_2.Text = jogador1;
                    contador++;
                    terminar_jogo();
                }
                else
                {
                    MessageBox.Show("Posição ocupada");
                }

            }
            else
            {
                
                if (tabuleiro[0, 1] == null)
                {
                    tabuleiro[0, 1] = jogador2;
                    btn_2.Text = jogador2;
                    contador++;
                    terminar_jogo();
                }
                else
                {
                    MessageBox.Show("Posição ocupada");
                }
            }
            
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            if (contador % 2 == 0)
            {
                if (tabuleiro[0, 2] == null)
                {
                    tabuleiro[0, 2] = jogador1;
                    btn_3.Text = jogador1;
                    contador++;
                    terminar_jogo();
                }
                else
                {
                    MessageBox.Show("Posição ocupada");
                }

            }
            else
            {
                
                if (tabuleiro[0, 2] == null)
                {
                    tabuleiro[0, 2] = jogador2;
                    btn_3.Text = jogador2;
                    contador++;
                    terminar_jogo();
                }
                else
                {
                    MessageBox.Show("Posição ocupada");
                }
            }
            
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            if (contador % 2 == 0)
            {
                if (tabuleiro[1, 0] == null)
                {
                    tabuleiro[1, 0] = jogador1;
                    btn_4.Text = jogador1;
                    contador++;
                    terminar_jogo();
                }
                else
                {
                    MessageBox.Show("Posição ocupada");
                }

            }
            else
            {
                if (tabuleiro[1, 0] == null)
                {
                    tabuleiro[1, 0] = jogador2;
                    btn_4.Text = jogador2;
                    contador++;
                    terminar_jogo();
                }
                else
                {
                    MessageBox.Show("Posição ocupada");
                }
            }
            
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            if (contador % 2 == 0)
            {
                if (tabuleiro[1, 1] == null)
                {
                    tabuleiro[1, 1] = jogador1;
                    btn_5.Text = jogador1;
                    contador++;
                    terminar_jogo();
                }
                else
                {
                    MessageBox.Show("Posição ocupada");
                }

            }
            else
            {
                if (tabuleiro[1, 1] == null)
                {
                    tabuleiro[1, 1] = jogador2;
                    btn_5.Text = jogador2;
                    contador++;
                    terminar_jogo();
                }
                else
                {
                    MessageBox.Show("Posição ocupada");
                }
            }
            
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            if (contador % 2 == 0)
            {
                
                if (tabuleiro[1, 2] == null)
                {
                    tabuleiro[1, 2] = jogador1;
                    btn_6.Text = jogador1;
                    contador++;
                    terminar_jogo();
                }
                else
                {
                    MessageBox.Show("Posição ocupada");
                }

            }
            else
            {
                
                if (tabuleiro[1, 2] == null)
                {
                    tabuleiro[1, 2] = jogador2;
                    btn_6.Text = jogador2;
                    contador++;
                    terminar_jogo();
                }
                else
                {
                    MessageBox.Show("Posição ocupada");
                }
            }
            
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            if (contador % 2 == 0)
            {
                
                if (tabuleiro[2, 0] == null)
                {
                    tabuleiro[2, 0] = jogador1;
                    btn_7.Text = jogador1;
                    contador++;
                    terminar_jogo();
                }
                else
                {
                    MessageBox.Show("Posição ocupada");
                }

            }
            else
            {
                
                if (tabuleiro[2, 0] == null)
                {
                    tabuleiro[2, 0] = jogador2;
                    btn_7.Text = jogador2;
                    contador++;
                    terminar_jogo();
                }
                else
                {
                    MessageBox.Show("Posição ocupada");
                }
            }
            
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            if (contador % 2 == 0)
            {
                
                if (tabuleiro[2, 1] == null)
                {
                    tabuleiro[2, 1] = jogador1;
                    btn_8.Text = jogador1;
                    contador++;
                    terminar_jogo();
                }
                else
                {
                    MessageBox.Show("Posição ocupada");
                }

            }
            else
            {
                
                if (tabuleiro[2, 1] == null)
                {
                    tabuleiro[2, 1] = jogador2;
                    btn_8.Text = jogador2;
                    contador++;
                    terminar_jogo();
                }
                else
                {
                    MessageBox.Show("Posição ocupada");
                }
            }
            
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            if (contador % 2 == 0)
            {
                
                if (tabuleiro[2, 2] == null)
                {
                    tabuleiro[2, 2] = jogador1;
                    btn_9.Text = jogador1;
                    contador++;
                    terminar_jogo();
                }
                else
                {
                    MessageBox.Show("Posição ocupada");
                }

            }
            else
            {
                
                if (tabuleiro[2, 2] == null)
                {
                    tabuleiro[2, 2] = jogador2;
                    btn_9.Text = jogador2;
                    contador++;
                    terminar_jogo();
                }
                else
                {
                    MessageBox.Show("Posição ocupada");
                }
            }
            
        }

        private void terminar_jogo()
        {
            for (int i = 0; i < 3; i++)
            {
                if (tabuleiro[i, 0] == "X" && tabuleiro[i, 1] == "X" && tabuleiro[i, 2] == "X")
                {
                    MessageBox.Show($"Jogador 1 - Venceu");
                    Clear();
                }
                if (tabuleiro[i, 0] == "O" && tabuleiro[i, 1] == "O" && tabuleiro[i, 2] == "O")
                {
                    MessageBox.Show($"Jogador 2 - Venceu");
                    Clear();
                }

                if (tabuleiro[0, i] == "X" && tabuleiro[1, i] == "X" && tabuleiro[2, i] == "X")
                {
                    MessageBox.Show($"Jogador 1 - Venceu");
                    Clear();
                }
                if (tabuleiro[0, i] == "O" && tabuleiro[1, i] == "O" && tabuleiro[2, i] == "O")
                {
                    MessageBox.Show($"Jogador 2 - Venceu");
                    Clear();
                }
                if (tabuleiro[0, 0] == "X" && tabuleiro[1, 1] == "X" && tabuleiro[2, 2] == "X")
                {
                    MessageBox.Show($"Jogador 1 - Venceu");
                    Clear();
                }
                if (tabuleiro[0, 0] == "O" && tabuleiro[1, 1] == "O" && tabuleiro[2, 2] == "O")
                {
                    MessageBox.Show($"Jogador 2 - Venceu");
                    Clear();
                }
                if (tabuleiro[0, 2] == "X" && tabuleiro[1, 1] == "X" && tabuleiro[2, 0] == "X")
                {
                    MessageBox.Show($"Jogador 1 - Venceu");
                    Clear();
                }
                if (tabuleiro[0, 2] == "O" && tabuleiro[1, 1] == "O" && tabuleiro[2, 0] == "O")
                {
                    MessageBox.Show($"Jogador 2 - Venceu");
                    Clear();
                }
                if (contador == 9)
                {
                    MessageBox.Show($"Empatou");
                    Clear();
                }
            }
        }
        

        private void Clear()
        {
            tabuleiro = new string[3, 3];
            btn1.Text = String.Empty;
            btn_2.Text = String.Empty;
            btn_3.Text = String.Empty;
            btn_4.Text = String.Empty;
            btn_5.Text = String.Empty;
            btn_6.Text = String.Empty;
            btn_7.Text = String.Empty;
            btn_8.Text = String.Empty;
            btn_9.Text = String.Empty;
            contador = 0;
        }

       
    }
}
