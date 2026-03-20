using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Draft;

namespace Entrega_1___PI
{
    public partial class Tabuleiro : Form
    {
        private Jogador jogadorAtual;
        private string jogadorSorteado;
        public Tabuleiro(Jogador jogador, string JogadorSorteado)
        {
            InitializeComponent();
            jogadorAtual = jogador;
            jogadorSorteado = JogadorSorteado;
            
        }
        private void Tabuleiro_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Partida iniciada! Jogador sorteado para começar: " + jogadorSorteado);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExibirMao_Click(object sender, EventArgs e)
        {
            lblMao.Text = ("Meus Dinossauros: " + Draft.Jogo.ExibirMao(jogadorAtual.Id, jogadorAtual.Senha));
        }

        
    }
}
