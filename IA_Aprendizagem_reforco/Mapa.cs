using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IA_Aprendizagem_reforco
{
    class Mapa
    {
        private List<Posicao> mapa = new List<Posicao>();
        private List<int> visitado;
        private Array posicaoPreta = new int[17] {7,10,11,14,19,20,21,24,25,26,27,30,31,37,39,40,41};
        private int posicaoInicial = 1;
        private int posicaoDestino = 50;


        public Mapa()
        {
            //cria as 50 posicoes definidas e as posicoes vizinhas
            for(int i = 1; i <= 50; i++)
            {
                Posicao p = new Posicao();
                /*não está certo, tem que ajustar a tabela, a sequencia não fecha.
                if (Esquerda(i+1))
                    p.Vizinhos.Add(i - 5);
                if (Cima(i + 1))
                    p.Vizinhos.Add(i + 1);
                if (Baixo(i + 1))
                    p.Vizinhos.Add(i - 1);
                if (Direita(i + 1))
                    p.Vizinhos.Add(i + 5);*/
                mapa.Add(p);
            }
            //define quem são as posicoes pretas
            foreach (int i in posicaoPreta)
            {
                mapa[i-1].Recompensa = -100;
            }
        }


        private Boolean Esquerda(int i)
        {
            if (i <= 5)
                return false;
            return true;
        }
        private Boolean Direita(int i)
        {
            if (i >= 46)
                return false;
            return true;
        }
        //não está certo
        private Boolean Cima(int i)
        {
            if ((i % 5 == 0 && i % 2 != 0) || (i-1 % 5 == 0 && i-1 % 2 != 0))
                return false;
            return true;
        }
        //não está certo
        private Boolean Baixo(int i)
        {
            if ((i % 10 == 0 && i % 2 == 0) || (i-1 % 10 == 0 && i-1 % 2 == 0))
                return false;
            return true;
        }

    }
}
