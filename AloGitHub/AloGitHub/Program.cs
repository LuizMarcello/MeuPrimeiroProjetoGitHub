using System;

namespace AloGitHub
{
    class Program
    { 
        static void Escrevenatela(string txt)
        {
            Console.WriteLine(txt);
        }

        static void Escrevenatela2(string txt)
        {
            Escrevenatela(txt);
        }

        static void Escrevenatela3(string txt)
        {
            Escrevenatela2(txt);
        }

        static void Main(string[] args)
        {
            Escrevenatela("Primeiro teste com o github");
            Console.ReadKey();
        }
    }
}
            
