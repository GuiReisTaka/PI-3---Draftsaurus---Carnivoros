using Draft;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega_1___PI
{
    internal class EstadoTabuleiro
    {
        private Jogador _jogador;

        public EstadoTabuleiro(Jogador jogador)
        {
            _jogador = jogador;
        }

        public Dictionary<string, string> ObterEstado()
        {
            Dictionary<string, string> estado = new Dictionary<string, string>();

            string tabuleiro = Jogo.ExibirTabuleiro(_jogador.Id, _jogador.Senha);

            if (tabuleiro.StartsWith("ERRO"))
                return estado;

            tabuleiro = tabuleiro.Replace("\r", "");
            string[] linhas = tabuleiro.Split('\n');

            foreach (string linha in linhas)
            {
                if (linha.Trim() == "") continue;
                string[] dados = linha.Split(',');
                if (dados.Length >= 2)
                    estado[dados[0].Trim()] = dados[1].Trim();
            }

            return estado;
        }

        //Obtem a quantidade de dinossauros em cada cercado, para facilitar a validação das jogadas
        public Dictionary<string, int> ObterQuantidadePorCercado()
        {
            Dictionary<string, int> quantidade = new Dictionary<string, int>();

            string tabuleiro = Jogo.ExibirTabuleiro(_jogador.Id, _jogador.Senha);

            if (tabuleiro.StartsWith("ERRO"))
                return quantidade;

            tabuleiro = tabuleiro.Replace("\r", "");
            string[] linhas = tabuleiro.Split('\n');

            foreach (string linha in linhas)
            {
                if (linha.Trim() == "") continue;
                string[] dados = linha.Split(',');
                if (dados.Length >= 3)
                {
                    string cercado = dados[0].Trim();
                    int qtd = int.Parse(dados[2].Trim());
                    if (quantidade.ContainsKey(cercado))
                        quantidade[cercado] += qtd;
                    else
                        quantidade[cercado] = qtd;
                }
            }

            return quantidade;
        }

        //Obtem quais dinossauros estão em cada cercado, para facilitar a validação das jogadas
        public Dictionary<string, List<string>> ObterDinosPorCercado()
        {
            Dictionary<string, List<string>> dinos = new Dictionary<string, List<string>>();
            string tabuleiro = Jogo.ExibirTabuleiro(_jogador.Id, _jogador.Senha);
            if (tabuleiro.StartsWith("ERRO"))
                return dinos;
            tabuleiro = tabuleiro.Replace("\r", "");
            string[] linhas = tabuleiro.Split('\n');
            foreach (string linha in linhas)
            {
                if (linha.Trim() == "") continue;
                string[] dados = linha.Split(',');
                if (dados.Length >= 2)
                {
                    string cercado = dados[0].Trim();
                    string dino = dados[1].Trim();
                    if (!dinos.ContainsKey(cercado))
                        dinos[cercado] = new List<string>();
                    dinos[cercado].Add(dino);
                }
            }
            return dinos;
        }
    }
}
