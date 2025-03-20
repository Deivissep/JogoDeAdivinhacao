namespace JogoDeAdivinhacaoConsoleApp
{
    internal class Program
    {
        //V2.0 - Gerar numero secreto aleatório
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

            Console.WriteLine("Você digitou o número: " + numeroDigitado);
            Console.WriteLine("O numero secreto é: " + numeroSecreto);

            Console.ReadLine();
        }
    }
}
