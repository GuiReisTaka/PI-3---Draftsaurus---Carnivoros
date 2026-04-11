using Draft;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entrega_1___PI
{
    public partial class Tabuleiro : Form
    {
        private Jogador jogadorAtual;
        private string jogadorSorteado;
        private int IdPartida;
        public Tabuleiro(Jogador jogador, string JogadorSorteado, int idPartida)
        {
            InitializeComponent();
            jogadorAtual = jogador;
            jogadorSorteado = JogadorSorteado;
            IdPartida = idPartida;
        }
        private void Tabuleiro_Load(object sender, EventArgs e)
        {
            string[] dadosSorteado = jogadorSorteado.Split(',');
            lblJogadorSorteado.Text = "Jogador Sorteado: " + dadosSorteado[1];

            string retorno = Jogo.ListarJogadores(IdPartida);
            if (retorno.StartsWith("ERRO"))
            {
                MessageBox.Show("Erro ao listar jogadores da partida");
                return;
            }

            retorno = retorno.Replace("\r", "");
            string[] jogadores = retorno.Split('\n');

            lstJogadoresNaPartida.Items.Clear();
            for (int i = 0; i < jogadores.Length - 1; i++)
            {
                lstJogadoresNaPartida.Items.Add(jogadores[i]);
            }

            string turno = Jogo.VerificarPartida(IdPartida);
            string[] dadosTurno = turno.Split(',');
            lblTurno.Text = "Turno: " + dadosTurno[1];

            string codigoDado = dadosTurno[4];

            string facesRetorno = Jogo.ListarFacesDado();
            facesRetorno = facesRetorno.Replace("\r", "");
            string[] faces = facesRetorno.Split('\n');
            foreach (string face in faces)
            {
                string[] dadosFace = face.Split(',');
                if (dadosFace[0].Trim() == codigoDado.Trim())
                {
                    lblFaceDado.Text = "Face do Dado: " + dadosFace[1];
                    break;
                }
            }

            string idJogadorDado = dadosTurno[3];

            foreach (string jogador in jogadores)
            {
                string[] dadosJogador = jogador.Split(',');
                if (dadosJogador[0] == idJogadorDado)
                {
                    lblJogadorSorteado.Text = "Jogador Sorteado: " + dadosJogador[1];
                    break;
                }
            }

            //VerificarVezDeJogar.Start();
        }




        private void RealizarJogada()
        {
            string turno = Jogo.VerificarPartida(IdPartida);
            string[] dadosTurno = turno.Split(',');
            if (dadosTurno[2] != "A")
                return;

            string idJogadorDado = dadosTurno[3];
            string codigoDado = dadosTurno[4].Trim();

            string turnoDetalhado = Jogo.VerificarTurno(IdPartida);
            turnoDetalhado = turnoDetalhado.Replace("\r", "");
            string[] linhasTurno = turnoDetalhado.Split('\n');

            bool jaJogou = false;
            for (int i = 1; i < linhasTurno.Length; i++)
            {
                string[] dadosJogada = linhasTurno[i].Split(',');
                if (dadosJogada[0].Trim() == jogadorAtual.Id.ToString())
                {
                    jaJogou = true;
                    break;
                }
            }
            if (jaJogou) return;

            // Pega o estado do tabuleiro antes de tudo
            EstadoTabuleiro estadoTabuleiro = new EstadoTabuleiro(jogadorAtual);
            Dictionary<string, string> estado = estadoTabuleiro.ObterEstado();

            // Pega o dinossauro da mão
            string mao = Jogo.ExibirMao(jogadorAtual.Id, jogadorAtual.Senha);
            mao = mao.Replace("\r", "");
            string[] dinossauros = mao.Split('\n');

            string dinossauroEscolhido = "";
            for (int i = 1; i < dinossauros.Length; i++)
            {
                if (dinossauros[i].Trim() != "")
                {
                    string[] dadosDino = dinossauros[i].Split(',');
                    dinossauroEscolhido = dadosDino[0].Trim();
                    break;
                }
            }

            if (dinossauroEscolhido == "")
            {
                MessageBox.Show("Nenhum dinossauro na mão!");
                return;
            }

            // Define cercados válidos baseado no dado
            List<string> cercadosValidos = new List<string>();

            if (codigoDado == "AL")
                cercadosValidos.AddRange(new[] { "FI", "MT", "PA" });
            else if (codigoDado == "WC")
                cercadosValidos.AddRange(new[] { "RS", "CD", "IS" });
            else if (codigoDado == "FL")
                cercadosValidos.AddRange(new[] { "FI", "MT", "RS" });
            else if (codigoDado == "PR")
                cercadosValidos.AddRange(new[] { "PA", "CD", "IS" });
            else if (codigoDado == "TI")
            {
                string[] todosCercados = { "FI", "MT", "PA", "RS", "CD", "IS", "RI" };
                foreach (string cercado in todosCercados)
                {
                    if (!estado.ContainsKey(cercado) || estado[cercado] != "Ti")
                        cercadosValidos.Add(cercado);
                }
            }
            else if (codigoDado == "VZ")
            {
                string[] todosCercados = { "FI", "MT", "PA", "RS", "CD", "IS", "RI" };
                foreach (string cercado in todosCercados)
                {
                    if (!estado.ContainsKey(cercado))
                        cercadosValidos.Add(cercado);
                }
            }
            else
                cercadosValidos.AddRange(new[] { "FI", "MT", "PA", "RS", "CD", "IS", "RI" });

            Dictionary<string, int> quantidade = estadoTabuleiro.ObterQuantidadePorCercado();
            Dictionary<string, List<string>> dinosPorCercado = estadoTabuleiro.ObterDinosPorCercado();
            ValidadorCercado validador = new ValidadorCercado(estado, quantidade, dinosPorCercado);
            string cercadoEscolhido = "RI"; // padrão é o Rio se nenhum cercado for válido

            foreach (string cercado in cercadosValidos)
            {
                if (validador.PodeJogarEm(cercado, dinossauroEscolhido))
                {
                    cercadoEscolhido = cercado;
                    break;
                }
            }

            string resultado = Jogo.Jogar(jogadorAtual.Id, jogadorAtual.Senha, dinossauroEscolhido, cercadoEscolhido);
            MessageBox.Show("Jogada realizada! O dinossauro: " + dinossauroEscolhido + " foi colocado no cercado: " + cercadoEscolhido);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExibirMao_Click(object sender, EventArgs e)
        {
            AtualizarMao();
            lblMao.Text = ("Meus Dinossauros: " + Draft.Jogo.ExibirMao(jogadorAtual.Id, jogadorAtual.Senha));
        }

        private void lblTurno_Click(object sender, EventArgs e)
        {

        }


        private void AtualizarInfoTurno()
        {
            string turno = Jogo.VerificarPartida(IdPartida);
            string[] dadosTurno = turno.Split(',');
            lblTurno.Text = "Turno: " + dadosTurno[1];

            string codigoDado = dadosTurno.Length >= 5 ? dadosTurno[4].Trim() : "";
            string facesRetorno = Jogo.ListarFacesDado();
            facesRetorno = facesRetorno.Replace("\r", "");
            string[] faces = facesRetorno.Split('\n');
            foreach (string face in faces)
            {
                string[] dadosFace = face.Split(',');
                if (dadosFace[0].Trim() == codigoDado.Trim())
                {
                    lblFaceDado.Text = "Face do Dado: " + dadosFace[1];
                    break;
                }
            }

            if (!string.IsNullOrEmpty(codigoDado.Trim()))
            {
                string caminhoImagem = Application.StartupPath + @"\Imagens\Dado\" + codigoDado.Trim() + ".png";
                if (System.IO.File.Exists(caminhoImagem))
                {
                    picDado.Image = Image.FromFile(caminhoImagem);
                    picDado.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }


            string retornoJogadores = Jogo.ListarJogadores(IdPartida);
            retornoJogadores = retornoJogadores.Replace("\r", "");
            string[] jogadores = retornoJogadores.Split('\n');
            string idJogadorDado = dadosTurno[3];
            foreach (string jogador in jogadores)
            {
                string[] dadosJogador = jogador.Split(',');
                if (dadosJogador[0] == idJogadorDado)
                {
                    lblJogadorSorteado.Text = "Jogador Sorteado: " + dadosJogador[1];
                    break;
                }
            }

            if (!string.IsNullOrEmpty(codigoDado.Trim()))
            {
                string caminhoImagem = Application.StartupPath + @"\Imagens\Dado\" + codigoDado.Trim() + ".png";
                picDado.Image = Image.FromFile(caminhoImagem);
                picDado.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }


        private void VerificarVezDeJogar_Tick(object sender, EventArgs e)
        {
            VerificarVezDeJogar.Stop();
            AtualizarInfoTurno();
            RealizarJogada();
            VerificarVezDeJogar.Start();
        }

        private void txtExibirTabuleiro_TextChanged(object sender, EventArgs e)
        {

        }

        private void AtualizarMao()
        {
            string mao = Jogo.ExibirMao(jogadorAtual.Id, jogadorAtual.Senha);
            mao = mao.Replace("\r", "");
            string[] linhas = mao.Split('\n');

            PictureBox[] picsMao = { picMao1, picMao2, picMao3, picMao4, picMao5, picMao6 };

            // limpa todos primeiro
            foreach (PictureBox pic in picsMao)
                pic.Image = null;

            int index = 0;
            for (int i = 1; i < linhas.Length; i++)
            {
                if (linhas[i].Trim() == "") continue;
                string[] dados = linhas[i].Split(',');
                string codigoDino = dados[0].Trim();
                int quantidade = int.Parse(dados[1].Trim());

                for (int q = 0; q < quantidade && index < 6; q++)
                {
                    string caminho = Application.StartupPath + @"\Imagens\Dinossauros\" + codigoDino + ".png";
                    if (System.IO.File.Exists(caminho))
                    {
                        picsMao[index].Image = Image.FromFile(caminho);
                        picsMao[index].SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    index++;
                }
            }
        }

        private void btnExibirTabuleiro_Click(object sender, EventArgs e)
        {

            string tabuleiro = Jogo.ExibirTabuleiro(jogadorAtual.Id, jogadorAtual.Senha);
            txtExibirTabuleiro.Text = tabuleiro;
          
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lstJogadoresNaPartida_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void picMao1_Click(object sender, EventArgs e)
        {

        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            string cercado = txtCercado.Text.Trim().ToUpper();
            string dinossauro = txtDinossauro.Text.Trim();

            if (cercado == "" || dinossauro == "")
            {
                MessageBox.Show("Preencha o cercado e o dinossauro!");
                return;
            }

            string resultado = Jogo.Jogar(jogadorAtual.Id, jogadorAtual.Senha, dinossauro, cercado);

            if (resultado.StartsWith("ERRO"))
            {
                MessageBox.Show(resultado);
                return;
            }

            MessageBox.Show("Jogada realizada! Próximo turno: " + resultado);
            AtualizarInfoTurno();
            txtCercado.Clear();
            txtDinossauro.Clear();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarInfoTurno();
        }
    }
}
