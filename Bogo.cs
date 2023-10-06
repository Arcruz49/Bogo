using System;

namespace ConsoleApp2
{
    public class Bogo
    {
        public int[] sort(int[] vet)
             {
                Random random = new Random();
                int cont = 1;
                while (!isSorted(vet))
                {
                    for(int i = 0; i < vet.Length; i++)
                    {
                        int rnd = random.Next(0, vet.Length);
                        (vet[i], vet[rnd]) = (vet[rnd], vet[i]);
                    }
                    cont++;
                }
                return vet;
            }

            public int search(int n, int[] vet)
            {
                Random random = new Random();
                int posicao = 0;
                foreach(int i in vet)
                {
                    if (i == n) return posicao;
                    posicao++;
                }
                return -1;
            }

            private bool isSorted(int[] vet)
            {
                for(int i = 1; i < vet.Length; i++)
                {
                    if (vet[i] < vet[i - 1]) return false;
                }
                return true;
            }

            public void imprimeVetor(int[] vet)
            {
                foreach (int n in vet) Console.Write("[{0}]",n);
                Console.WriteLine("");
            }
    }
    
}
