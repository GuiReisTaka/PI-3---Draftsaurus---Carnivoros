using Draft;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entrega_1___PI
{
    internal class Partida
    {
        public int id { get; set; }
        public string nome { get; set; }
        public DateTime data { get; set; }
        public char status { get; set; }

        public static List<Partida> ListarPartidas()
        {
            string retorno = Jogo.ListarPartidas("T");
            

            retorno = retorno.Replace("\r", "");
            retorno = retorno.Substring(0, retorno.Length - 1);
            string[] partidas = retorno.Split('\n');
            List<Partida> listaPartidas = new List<Partida>();

            for (int i = 0; i < partidas.Length; i++)
            {
                string partida = partidas[i];
                string[] dados = partida.Split(',');

                Partida p = new Partida();
                p.id = Convert.ToInt32(dados[0]);
                p.nome = dados[1];
                p.data = Convert.ToDateTime(dados[2]);
                p.status = Convert.ToChar(dados[3]);

                listaPartidas.Add(p);
            }
            return listaPartidas;
        }
    }
}
