using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IA_Aprendizagem_reforco
{
    class Posicao
    {
        private int recompensa = 0;
        private List<int> vizinhos = new List<int>();


        public Posicao() { }



        public void setRecompensa(int recompensa)
        {
            this.recompensa = recompensa;
        }
        
        public int Recompensa { get => recompensa; set => recompensa = value; }
        public List<int> Vizinhos { get => vizinhos; set => vizinhos = value; }
    }
}
