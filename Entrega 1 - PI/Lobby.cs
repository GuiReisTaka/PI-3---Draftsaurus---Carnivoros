using Draft;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entrega_1___PI
{
    public partial class Lobby : Form
    {
        public Lobby()
        {
            InitializeComponent();
            lblVersao.Text = Jogo.versao;

            dgvListaPartida.DataSource = Partida.ListarPartidas();
            dgvListaPartida.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListaPartida.MultiSelect = false;
            dgvListaPartida.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvListaPartida.AllowUserToResizeRows = false;
            dgvListaPartida.AllowUserToResizeColumns = false;
            dgvListaPartida.RowHeadersVisible = false;

            ConfigurarDgv();
        }

        private void Lobby_Load_1(object sender, EventArgs e)
        {
            ConfigurarDgv();
            _formCarregado = true;
        }

        private int _idPartidaSelecionada;
        private bool _formCarregado = false;

        private void button1_Click(object sender, EventArgs e)
        {
            _formCarregado = false;
            ConfigurarDgv();
            _formCarregado = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblVersao_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCriarPartida_Click(object sender, EventArgs e)
        {
            string nomePartida = txtNomePartida.Text;
            string senhaPartida = txtSenhaPartida.Text;
            string nomeGrupo = "Carnivoros";

            if(nomePartida == "" || senhaPartida == "" || nomeGrupo == "")
            {
                MessageBox.Show("Preencha todos os campos para criar uma partida");
                return;
            }

            if(nomePartida.Contains(",") || senhaPartida.Contains(",") || nomeGrupo.Contains(","))
            {
                MessageBox.Show("Os campos não podem conter vírgulas");
                return;
            }

            if(nomePartida.Length > 15)
            {
                MessageBox.Show("O nome não pode conter mais do que 15 caracteres");
                return;
            }

            if (senhaPartida.Length > 10)
            {
                MessageBox.Show("A senha não pode conter mais do que 10 caracteres");
                return;
            }

            string id = Jogo.CriarPartida(nomePartida, senhaPartida, nomeGrupo);
            lblIdPartidaCriada.Text = "ID da Partida Criada: " + id;

        }

        private void lblDataPartida_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrarPartida_Click(object sender, EventArgs e)
        {
            string senhaPartida = txtEntrarPartida.Text;
            string nomeJogador = "Carnivoros";

            if (senhaPartida == "" || nomeJogador == "")
            {
                MessageBox.Show("Preencha todos os campos para entrar em uma partida");
                return;
            }

            if (senhaPartida.Contains(",") || nomeJogador.Contains(","))
            {
                MessageBox.Show("Os campos não podem conter vírgulas");
                return;
            }

            if(nomeJogador.Length > 20)
            {
                MessageBox.Show("O nome não pode conter mais do que 20 caracteres");
                return;
            }

            if (senhaPartida.Length > 10)
            {
                MessageBox.Show("A senha não pode conter mais do que 10 caracteres");
                return;
            }

            if(_idPartidaSelecionada == 0)
            {
                MessageBox.Show("Selecione uma partida para entrar");
                return;
            }

            string entrar = Jogo.Entrar(_idPartidaSelecionada, nomeJogador, senhaPartida);

            if (entrar.StartsWith("ERRO"))
            {
                MessageBox.Show("A senha está errada! Tente novamente com a senha certa.");
                return;
            }

            string[] partes = entrar.Split(',');

            if (partes.Length < 2)
            {
                MessageBox.Show("Retorno inesperado: " + entrar); // debug
                return;
            }

            lblIdJogador.Text = "ID do Jogador: " + partes[0];
            lblSenhaJogador.Text = "Senha do Jogador: " + partes[1];

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void lstJogadoresDaPartida_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnIniciarPartida_Click(object sender, EventArgs e)
        {
            if (lstJogadoresDaPartida.Items.Count < 2)
            {
                MessageBox.Show("É preciso de duas ou mais pessoas para iniciar a partida!");
                return;
            }

            string idJogador = lblIdJogador.Text.Replace("ID do Jogador: ", "");
            string senhaJogador = lblSenhaJogador.Text.Replace("Senha do Jogador: ", "");

            if (idJogador == "" || senhaJogador == "")
            {
                MessageBox.Show("Você precisa entrar na partida antes de iniciá-la!");
                return;
            }

            int idJogadorInt = int.Parse(idJogador);
            string iniciar = Jogo.Iniciar(idJogadorInt, senhaJogador);

            Jogador jogador = new Jogador();
            jogador.Id = idJogadorInt;
            jogador.Senha = senhaJogador;

            Tabuleiro tabuleiro = new Tabuleiro(jogador, iniciar);
            tabuleiro.ShowDialog();

            MessageBox.Show("Partida iniciada! Jogador sorteado para começar: " + iniciar);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void ConfigurarDgv()
        {

            dgvListaPartida.DataSource = null;
            dgvListaPartida.DataSource = Partida.ListarPartidas();

            dgvListaPartida.Columns["id"].Visible = false;
            dgvListaPartida.Columns["data"].Visible = false;
            dgvListaPartida.Columns["nome"].HeaderText = "Nome";
            dgvListaPartida.Columns["nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvListaPartida.Columns["status"].HeaderText = "Status";
            dgvListaPartida.Columns["status"].Width = 50;
        }

        private void dgvListaPartida_SelectionChanged(object sender, EventArgs e)
        {
            if (!_formCarregado) return;
            if (dgvListaPartida.SelectedRows.Count == 0) return;

            DataGridViewRow linhaSelecionada = dgvListaPartida.SelectedRows[0];

            int idPartida = Convert.ToInt32(linhaSelecionada.Cells["id"].Value);
            string nomePartida = linhaSelecionada.Cells["nome"].Value.ToString();
            string dataPartida = linhaSelecionada.Cells["data"].Value.ToString();

            _idPartidaSelecionada = idPartida;

            lblIdpartida.Text = "ID: " + idPartida;
            lblNomeDaPartida.Text = "Nome: " + nomePartida;
            lblDataPartida.Text = "Data de Criação: " + Convert.ToDateTime(linhaSelecionada.Cells["data"].Value).ToString("dd/MM/yyyy");
            lblPatidaSelecionada.Text = "Partida Selecionada: " + nomePartida;

            string retorno = Jogo.ListarJogadores(idPartida);
            if (retorno.StartsWith("ERRO"))
            {
                MessageBox.Show("Erro ao listar jogadores da partida");
                return;
            }

            retorno = retorno.Replace("\r", "");
            string[] jogadores = retorno.Split('\n');

            lstJogadoresDaPartida.Items.Clear();
            if (jogadores.Length < 2)
            {
                MessageBox.Show("Nenhum jogador encontrado na partida: " + nomePartida);
                return;
            }

            for (int i = 0; i < jogadores.Length - 1; i++)
                lstJogadoresDaPartida.Items.Add(jogadores[i]);
        }

        
    }
}
