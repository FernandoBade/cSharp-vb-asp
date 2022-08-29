namespace Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Utilizando o laço 'while'.");
            double investimentoWhile = 1000;
            double rendimento = 0.005;
            int mesWhile = 1;
/*            while(mesWhile <= 12)
            {
                investimentoWhile += investimentoWhile * rendimento;
                Console.WriteLine("No mês " + mesWhile + " você tem um total de R$" + Math.Round(investimentoWhile,2) + " em investimentos.");
                mesWhile++;
            }

            double investimentoFor = 1000;
            int mesFor = 1;
            Console.WriteLine("Utilizando o laço 'for'.");
            for(int i = 0; mesFor <= 12; i++)
            {
                investimentoFor += investimentoFor * rendimento;
                Console.WriteLine("No mês " + mesFor + " você tem um total de R$" + Math.Round(investimentoFor, 2) + " em investimentos.");
                mesFor++;
            }*/
            do
            {

                    investimentoWhile += investimentoWhile * rendimento;
                    Console.WriteLine("No mês " + mesWhile + " você tem um total de R$" + Math.Round(investimentoWhile, 2) + " em investimentos.");
                    mesWhile++;
            } while (mesWhile <= 12);

        }
    }
}