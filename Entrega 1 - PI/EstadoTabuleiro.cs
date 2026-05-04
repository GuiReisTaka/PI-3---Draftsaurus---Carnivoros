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

        string tabuleiro;

        public EstadoTabuleiro(Jogador jogador)
        {
            _jogador = jogador;
            tabuleiro = Jogo.ExibirTabuleiro(_jogador.Id, _jogador.Senha);
        }

        public Dictionary<string, string> ObterEstado()
        {
            Dictionary<string, string> estado = new Dictionary<string, string>();

            if (tabuleiro.StartsWith("ERRO"))
                return estado;

            string tabuleiroLimpo = tabuleiro.Replace("\r", "");
            string[] linhas = tabuleiroLimpo.Split('\n');

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

            if (tabuleiro.StartsWith("ERRO"))
                return quantidade;

            string tabuleiroLimpo = tabuleiro.Replace("\r", "");
            string[] linhas = tabuleiroLimpo.Split('\n');

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
            if (tabuleiro.StartsWith("ERRO"))
                return dinos;
            string tabuleiroLimpo = tabuleiro.Replace("\r", "");
            string[] linhas = tabuleiroLimpo.Split('\n');
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
