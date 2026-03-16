using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Draft;

namespace Entrega_1___PI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblVersao.Text = Jogo.versao;
        }
        private int _idPartidaSelecionada;
        private int _senhaPartidaSelecionada;

        private void button1_Click(object sender, EventArgs e)
        {
            String retorno = Jogo.ListarPartidas("T");

            retorno = retorno.Replace("/r", "");
            retorno = retorno.Substring(0, retorno.Length - 1);
            string[] partidas = retorno.Split('\n');
            
            lstListaDePartidas.Items.Clear();   
            for (int i = 0; i < partidas.Length; i++) { 
                lstListaDePartidas.Items.Add(partidas[i]);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lstListaDePartidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string partida = lstListaDePartidas.SelectedItem.ToString();
            string[] dadosPartida = partida.Split(',');

            int idPartida = int.Parse(dadosPartida[0]);
            _idPartidaSelecionada = idPartida;
            string nomePartida = dadosPartida[1];
            string dataPartida = dadosPartida[2];

            lblIdpartida.Text = "ID: " + idPartida.ToString();
            lblNomeDaPartida.Text = "Nome: " + nomePartida;
            lblDataPartida.Text = "Data de Criação: " + dataPartida;

            string retorno = Jogo.ListarJogadores(idPartida);
            if(retorno.StartsWith("ERRO"))
            {
                MessageBox.Show("Erro ao listar jogadores da partida");
                return;
            }

            retorno = retorno.Replace("/r", "");
            string[] jogadores = retorno.Split('\n');

            lblPatidaSelecionada.Text = "Partida Selecionada: " + nomePartida;

            if (jogadores.Length == 1 ){
                lstJogadoresDaPartida.Items.Clear();
                MessageBox.Show("Nenhum jogador encontrado na partida: " + partida);
                return;
            }


            lstJogadoresDaPartida.Items.Clear();
            for (int i = 0; i < jogadores.Length - 1; i++)
            {
                lstJogadoresDaPartida.Items.Add(jogadores[i]);
            }

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
            lblIdJogador.Text = "ID do Jogador: " + entrar[0];
            if (lblIdJogador.Text == "ID do Jogador: E")
            {
                MessageBox.Show("A senha está errada! Tente novamente com a senha certa.");
                return;
            }
            lblSenhaJogador.Text = "Senha do Jogador: " + entrar[1];
        }

    }
}
