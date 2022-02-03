using System;

namespace CriandoPontoFlutuante
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 3 - Criando Variáveis Ponto Flutuante");

            double salario;
            salario = 1200.50;
            Console.WriteLine($"Exemplo de números flutuantes: {salario}");

            int salarioEmInteiro = (int)salario;
            Console.WriteLine($"Exemplo de conversão de Variável flutuante, para inteiro {salarioEmInteiro} ... Neste caso, perdemos a precisão do valor");

            long idade = 13000000000000;
            Console.WriteLine($"Exemplo de Variável inteiro acima de 32 bits: {idade}");

            short quantidadeDeProdutos = 150;
            Console.WriteLine($"Exemplo de Variável inteiro de 16 bits: {quantidadeDeProdutos}");

            float altura = 1.80f;
            Console.WriteLine($"Exemplo de Variável tipo Float (com pouca precisão) {altura}");

        }
    }
}