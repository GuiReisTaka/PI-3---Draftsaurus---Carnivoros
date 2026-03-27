using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega_1___PI
{
    internal class ValidadorCercado
    {
        private Dictionary<string, string> _estado;
        private Dictionary<string, int> _quantidade;

        public ValidadorCercado(Dictionary<string, string> estado, Dictionary<string, int> quantidade)
        {
            _estado = estado;
            _quantidade = quantidade;
        }

        public bool PodeJogarEm(string cercado, string dinossauro)
        {
            switch (cercado)
            {
                case "FI": // Floresta da Igualdade - só dinossauros da mesma espécie
                    if (!_estado.ContainsKey("FI")) return true;
                    return _estado["FI"] == dinossauro; 

                case "CD": // Campina da Diferença - só espécies diferentes
                    if (!_estado.ContainsKey("CD")) return true; 
                    return _estado["CD"] != dinossauro; 

                case "IS": // Ilha Solitária - só um dinossauro
                    int qtdIS = _quantidade.ContainsKey("IS") ? _quantidade["IS"] : 0;
                    return qtdIS == 0;

                case "RS": // Rei da Selva - só um dinossauro
                    int qtdRS = _quantidade.ContainsKey("RS") ? _quantidade["RS"] : 0;
                    return qtdRS == 0;

                case "MT": // Mata Tripla - até 3 dinossauros
                    int qtdMT = _quantidade.ContainsKey("MT") ? _quantidade["MT"] : 0;
                    return qtdMT < 3;

                case "PA": // Pradaria do Amor - qualquer dinossauro
                    return true;

                case "RI": // Rio - joga o que quiser
                    return true;

                default:
                    return false;
            }
        }
    }
}
