namespace Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade = 16;
            int qtdPessoas = 2;
            if (idade >= 18)
            {
                Console.WriteLine("Pode entrar!");
                Console.WriteLine("Pode entrar!");
            }
            else
            {
                if (qtdPessoas > 0)
                {
                    Console.WriteLine("Está acompanhado. Pode entrar!");
                }
                else
                {
                    Console.WriteLine("Não pode entrar! ");
                }
            }

            Console.WriteLine("Encerrando o módulo de condicionais.");
            Console.ReadLine();
        }
    }
}