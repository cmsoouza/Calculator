using System;

namespace Calculator // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
            //Soma();
            //Subtracao();
            //Multiplicacao();
            //Divisao();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Digite a opção desejada:");
            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1:
                    Soma();
                    break;
                case 2:
                    Subtracao();
                    break;
                case 3:
                    Multiplicacao();
                    break;
                case 4:
                    Divisao();
                    break;
                case 5:
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
        static void Soma()
        {
            Console.WriteLine(" Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine(" Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 + v2;
            //Console.WriteLine("O Resultado é: " + resultado);
            Console.WriteLine($"O Resultado é: {resultado}");
            //Console.WriteLine($"O Resultado da soma é: {v1 + v2}");
            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            Console.WriteLine(" Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine(" Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 - v2;
            Console.WriteLine($"O resultado é: {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine(" Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine(" Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 / v2;
            Console.WriteLine($"O resultado da divisão é: {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.WriteLine(" Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine(" Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 * v2;
            Console.WriteLine($"O resultado da multiplicação é: {v1 * v2}");
            Console.ReadKey();
            Menu();
        }
    }
}

/* 
    anotações:

    - Nesta aplicação o usuário digita o primeiro valor e o programa imprime o valor digitado.
    - Em todo os metodos usamos o parse() para converter uma string em um valor digitado para um tipo
      float.
    - Na l'20 é possivel realizarmos uma concatenação com variavel, usando o $.
    - A mesma coisa acontece na l'21, usando o { }. Assim usando as variaveis "v1" e "v2".
    - Tambem é possivel encapsular nossa aplicação em outro metodo, nete caso o metodo "Soma().
      assim podemos chamar o mesmo metodo em outro local.

    - Usando a condicional switch, podemos escolher qual metodo será chamado. Assim podemos
      chamar o metodo de forma dinamica e caso a opção seja invalida, o programa não irá executar.

 */