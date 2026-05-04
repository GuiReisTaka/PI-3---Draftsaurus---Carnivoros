using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega_1___PI
{
    public class EstrategiaJogada
    {
        private Dictionary<string, string> estado;
        private Dictionary<string, int> quantidade;
        private Dictionary<string, List<string>> dinosPorCercado;
        private int turnoAtual;

        public EstrategiaJogada(
            Dictionary<string, string> estado,
            Dictionary<string, int> quantidade,
            Dictionary<string, List<string>> dinosPorCercado,
            int turnoAtual)
        {
            this.estado = estado;
            this.quantidade = quantidade;
            this.dinosPorCercado = dinosPorCercado;
            this.turnoAtual = turnoAtual;
        }

        public (string dino, string cercado) EscolherMelhorJogada(
            List<string> cercadosValidos,
            string[] dinossauros)
        {
            Dictionary<string, int> mao = new Dictionary<string, int>();
            for (int i = 1; i < dinossauros.Length; i++)
            {
                if (dinossauros[i].Trim() == "") continue;
                string[] d = dinossauros[i].Split(',');
                if (d.Length < 2) continue;
                mao[d[0].Trim()] = int.Parse(d[1].Trim());
            }

            string melhorDino = "";
            string melhorCercado = "RI";
            double melhorPontuacao = -1;

            foreach (string cercado in cercadosValidos)
            {
                foreach (string dino in mao.Keys)
                {
                    ValidadorCercado validador = new ValidadorCercado(estado, quantidade, dinosPorCercado);
                    if (!validador.PodeJogarEm(cercado, dino)) continue;

                    double pontos = AvaliarJogada(cercado, dino, mao);

                    if (pontos > melhorPontuacao)
                    {
                        melhorPontuacao = pontos;
                        melhorDino = dino;
                        melhorCercado = cercado;
                    }
                }
            }

            if (melhorDino == "")
            {
                foreach (string dino in mao.Keys) { melhorDino = dino; break; }
                melhorCercado = "RI"; // garante que o cercado também é válido
            }

            return (melhorDino, melhorCercado);
        }

        private double AvaliarJogada(string cercado, string dino, Dictionary<string, int> mao)
        {
            int qtdAtual = quantidade.ContainsKey(cercado) ? quantidade[cercado] : 0;
            List<string> dinosNoCercado = dinosPorCercado.ContainsKey(cercado)
                ? dinosPorCercado[cercado] : new List<string>();

            switch (cercado)
            {
                case "FI":
                    {
                        int[] pontosFI = { 0, 2, 4, 8, 12, 18, 24 };
                        int novaQtd = qtdAtual + 1;
                        double pontosImediatos = pontosFI[novaQtd] - (qtdAtual > 0 ? pontosFI[qtdAtual] : 0);
                        double bonus = novaQtd == 6 ? 5 : 0;
                        return pontosImediatos + bonus;
                    }
                case "CD":
                    {
                        int[] pontosCD = { 0, 1, 3, 6, 10, 15, 21 };
                        if (dinosNoCercado.Contains(dino)) return -1;
                        int novaQtd = qtdAtual + 1;
                        double pontosImediatos = pontosCD[novaQtd] - (qtdAtual > 0 ? pontosCD[qtdAtual] : 0);
                        double bonus = novaQtd == 6 ? 5 : 0;
                        return pontosImediatos + bonus;
                    }
                case "MT":
                    {
                        if (qtdAtual == 2) return 7;
                        if (qtdAtual == 1) return 3;
                        if (qtdAtual == 0) return 2;
                        return -1;
                    }
                case "PA":
                    {
                        int qtdDinoNoCercado = dinosNoCercado.Count(d => d == dino);
                        return qtdDinoNoCercado % 2 == 1 ? 5 : 1;
                    }
                case "IS":
                    {
                        if (turnoAtual <= 6) return -1; // evita na primeira rodada
                        bool unicoNoZoo = true;
                        foreach (var par in dinosPorCercado)
                        {
                            if (par.Key == "IS") continue;
                            if (par.Value.Contains(dino)) { unicoNoZoo = false; break; }
                        }
                        return unicoNoZoo ? 7 : 1;
                    }
                case "RS":
                    {
                        return dino == "Ti" ? 6 : 2;
                    }
                case "RI":
                    {
                        return 0.5;
                    }
                default:
                    return 0;
            }
        }
    }
}

