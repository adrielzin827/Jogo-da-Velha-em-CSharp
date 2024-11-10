namespace Jogo_da_Velha
{
    public partial class Form1 : Form
    {
        private string[,] matriz = new string[3, 3];
        private string jogadorAtual = "X";
        private bool jogoAtivo = true;
        public Form1()
        {
            InitializeComponent();
        }

        private bool VerificarVencedor()
        {
            for (int i = 0; i < 3; i++)
            {
                if (matriz[i, 0] == jogadorAtual && matriz[i, 1] == jogadorAtual && matriz[i, 2] == jogadorAtual)

                    return true;

            }
            for (int i = 0; i < 3; i++)
            {
                if (matriz[0, i] == jogadorAtual && matriz[1, i] == jogadorAtual && matriz[2, i] == jogadorAtual)
                    return true;
            }
            if (matriz[0, 0] == jogadorAtual && matriz[1, 1] == jogadorAtual && matriz[2, 2] == jogadorAtual)
                return true;
            if (matriz[0, 2] == jogadorAtual && matriz[1, 1] == jogadorAtual && matriz[2, 0] == jogadorAtual)
                return true;

            return false;

        }

        private void btn_01_Click(object sender, EventArgs e)
        {
            Button btn_01 = sender as Button;
            if (jogoAtivo && string.IsNullOrEmpty(btn_01.Text))
            {
                btn_01.Text = jogadorAtual;
                int linha = (btn_01.TabIndex / 3);
                int coluna = (btn_01.TabIndex % 3);

                matriz[linha, coluna] = jogadorAtual;

                if (VerificarVencedor())
                {
                    MessageBox.Show(jogadorAtual + " Venceu!");
                    jogoAtivo = false;
                }
                else
                {
                    jogadorAtual = (jogadorAtual == "X") ? "O" : "X";
                }
            }
        }

        private void btn_02_Click(object sender, EventArgs e)
        {
            Button btn_02 = sender as Button;
            if (jogoAtivo && string.IsNullOrEmpty(btn_02.Text))
            {
                btn_02.Text = jogadorAtual;
                int linha = (btn_02.TabIndex / 3);
                int coluna = (btn_02.TabIndex % 3);

                matriz[linha, coluna] = jogadorAtual;

                if (VerificarVencedor())
                {
                    MessageBox.Show(jogadorAtual + " Venceu!");
                    jogoAtivo = false;
                }
                else
                {
                    jogadorAtual = (jogadorAtual == "X") ? "O" : "X";
                }
            }
        }


        private void btn_03_Click(object sender, EventArgs e)
        {
            Button btn_03 = sender as Button;
            if (jogoAtivo && string.IsNullOrEmpty(btn_03.Text))
            {
                btn_03.Text = jogadorAtual;
                int linha = (btn_03.TabIndex / 3);
                int coluna = (btn_03.TabIndex % 3);

                matriz[linha, coluna] = jogadorAtual;

                if (VerificarVencedor())
                {
                    MessageBox.Show(jogadorAtual + " Venceu!");
                    jogoAtivo = false;
                }
                else
                {
                    jogadorAtual = (jogadorAtual == "X") ? "O" : "X";
                }
            }
        }

        private void btn_11_Click(object sender, EventArgs e)
        {
            Button btn_11 = sender as Button;
            if (jogoAtivo && string.IsNullOrEmpty(btn_11.Text))
            {
                btn_11.Text = jogadorAtual;
                int linha = (btn_11.TabIndex / 3);
                int coluna = (btn_11.TabIndex % 3);

                matriz[linha, coluna] = jogadorAtual;

                if (VerificarVencedor())
                {
                    MessageBox.Show(jogadorAtual + " Venceu!");
                    jogoAtivo = false;
                }
                else
                {
                    jogadorAtual = (jogadorAtual == "X") ? "O" : "X";
                }
            }
        }

        private void btn_12_Click(object sender, EventArgs e)
        {
            Button btn_12 = sender as Button;
            if (jogoAtivo && string.IsNullOrEmpty(btn_12.Text))
            {
                btn_12.Text = jogadorAtual;
                int linha = (btn_12.TabIndex / 3);
                int coluna = (btn_12.TabIndex % 3);

                matriz[linha, coluna] = jogadorAtual;

                if (VerificarVencedor())
                {
                    MessageBox.Show(jogadorAtual + " Venceu!");
                    jogoAtivo = false;
                }
                else
                {
                    jogadorAtual = (jogadorAtual == "X") ? "O" : "X";
                }
            }
        }

        private void btn_13_Click(object sender, EventArgs e)
        {
            Button btn_13 = sender as Button;
            if (jogoAtivo && string.IsNullOrEmpty(btn_13.Text))
            {
                btn_13.Text = jogadorAtual;
                int linha = (btn_13.TabIndex / 3);
                int coluna = (btn_13.TabIndex % 3);

                matriz[linha, coluna] = jogadorAtual;

                if (VerificarVencedor())
                {
                    MessageBox.Show(jogadorAtual + " Venceu!");
                    jogoAtivo = false;
                }
                else
                {
                    jogadorAtual = (jogadorAtual == "X") ? "O" : "X";
                }
            }
        }

        private void btn_21_Click(object sender, EventArgs e)
        {
            Button btn_21 = sender as Button;
            if (jogoAtivo && string.IsNullOrEmpty(btn_21.Text))
            {
                btn_21.Text = jogadorAtual;
                int linha = (btn_21.TabIndex / 3);
                int coluna = (btn_21.TabIndex % 3);

                matriz[linha, coluna] = jogadorAtual;

                if (VerificarVencedor())
                {
                    MessageBox.Show(jogadorAtual + " Venceu!");
                    jogoAtivo = false;
                }
                else
                {
                    jogadorAtual = (jogadorAtual == "X") ? "O" : "X";
                }
            }
        }

        private void btn_22_Click(object sender, EventArgs e)
        {
            Button btn_22 = sender as Button;
            if (jogoAtivo && string.IsNullOrEmpty(btn_22.Text))
            {
                btn_22.Text = jogadorAtual;
                int linha = (btn_22.TabIndex / 3);
                int coluna = (btn_22.TabIndex % 3);

                matriz[linha, coluna] = jogadorAtual;

                if (VerificarVencedor())
                {
                    MessageBox.Show(jogadorAtual + " Venceu!");
                    jogoAtivo = false;
                }
                else
                {
                    jogadorAtual = (jogadorAtual == "X") ? "O" : "X";
                }
            }
        }

        private void btn_23_Click(object sender, EventArgs e)
        {
            Button btn_23 = sender as Button;
            if (jogoAtivo && string.IsNullOrEmpty(btn_23.Text))
            {
                btn_23.Text = jogadorAtual;
                int linha = (btn_23.TabIndex / 3);
                int coluna = (btn_23.TabIndex % 3);

                matriz[linha, coluna] = jogadorAtual;

                if (VerificarVencedor())
                {
                    MessageBox.Show(jogadorAtual + " Venceu!");
                    jogoAtivo = false;
                }
                else
                {
                    jogadorAtual = (jogadorAtual == "X") ? "O" : "X";
                }
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            jogadorAtual = "X";
            jogoAtivo = true;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matriz[i, j] = "";
                }
            }

            foreach (Button btn in this.Controls.OfType<Button>())
            {
                btn.Text = "";
                Reset.Text = "Resetar";
            }
        }
    }
}
