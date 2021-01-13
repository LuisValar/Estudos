using System;

namespace EntradaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();
            string s = Console.ReadLine();

            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);



            /* comando split 
                string s = console.ReadLine (); -> armazena toda dentro do s
                
                string [] vet = s.Split (' '); -> Irá reconhecer os espaços entre as palavras
            armazenando cada palavra em uma posição do vetor
                exemplo: posição valor
                            0    batata
                            1    tomare
                            2    abacaxi

             */
            string[] vetor = s.Split(' ');
            // adcina cada posição a uma variavel
            string a = vetor[0]; 
            string b = vetor[1];
            string c = vetor[2];

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

        }
    }
}
