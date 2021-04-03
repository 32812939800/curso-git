using System;

namespace Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;

            Console.WriteLine("A função do programa é percorrer um vetor e imprimir os dados alocados com o foreach");
            N = int.Parse(Console.ReadLine());
            string[] vet = new string[N];
            
            for (int i = 0; i < N; i++) {
                vet[i] = Console.ReadLine();
            }

            Console.WriteLine("Nomes lidos");
            foreach(string x in vet) {
                Console.WriteLine("Nome: " + x);
            }

            Console.ReadLine();
        }
    }
}
