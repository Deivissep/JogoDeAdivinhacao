namespace JogoDeAdivinhacaoConsoleApp
{
    internal class Program
    {
        //V3.0 - Gerar numero secreto aleatório
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Jogo de Adivinhação");
            Console.WriteLine("-------------------------------------");


            //lógica do jogo
            Random geradorDeNumeros = new Random();

            int numeroSecreto = geradorDeNumeros.Next(1, 21);

            Console.Write("Digite um numero (de 1 à 20) para chutar: ");
            int numeroDigitado = Convert.ToInt32(Console.ReadLine());

            if (numeroDigitado == numeroSecreto)
            {
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Parabéns, você acertou!");
                Console.WriteLine("-------------------------------------");
            }
            else if(numeroDigitado > numeroSecreto)
            {
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("O numero digitado foi maior que o numero secreto!");
                Console.WriteLine("-------------------------------------");
            }
            else
            {
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("O numero digitado foi menor que o numero secreto!");
                Console.WriteLine("-------------------------------------");
            }
                Console.ReadLine();
        }
    }
}
