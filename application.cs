using System;

namespace ImcApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Abaixo de 17    Muito abaixo do peso
            Entre 17 e 18,49    Abaixo do peso
            Entre 18,5 e 24,99  Peso normal
            Entre 25 e 29,99    Acima do peso
            Entre 30 e 34,99    Obesidade I
            Entre 35 e 39,99    Obesidade II(severa)
            Acima de 40 Obesidade III(mórbida)
            */

            Double altura;
            Double peso;
            Double imc;
            Console.WriteLine("*******************************************");
            Console.WriteLine("Cálculo de IMC :. Versão 1.0.0");
            Console.WriteLine("*******************************************");
            Console.WriteLine("\n");

            Console.WriteLine("Digite sua altura:  Exemplo : 1,90 ");
            altura = Double.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu peso: Exemplo : 52,9 ");
            peso = Double.Parse(Console.ReadLine());
            //Console.WriteLine("\n");
            Console.WriteLine("************************************************************************");

            //Cálculo do IMC
            imc = peso / (altura * altura);
            //Console.WriteLine(imc);

            if(imc < 17)
            {
                Console.WriteLine("Seu IMC é: " + Math.Round(imc, 2) + " e você está muito abaixo do peso!CUIDADO!!!");
            } else if (imc < 18.49)
            {
                Console.WriteLine("Seu IMC é: " + Math.Round(imc, 2) + " e você está abaixo do peso!");
            } else if (imc < 24.99)
            {
                Console.WriteLine("Seu IMC é: " + Math.Round(imc, 2) + " e seu peso está normal! Parabéns!!!");
            } else if (imc < 29.99)
            {
                Console.WriteLine("Seu IMC é: " + Math.Round(imc, 2) + " e você está acima do peso! CUIDADO!!!");
            } else if (imc < 34.99)
            {
                Console.WriteLine("Seu IMC é: " + Math.Round(imc, 2) + " e você está com Obesidade grau I!PROCURE UM MÉDICO!!!");
            } else if (imc < 39.99)
            {
                Console.WriteLine("Seu IMC é: " + Math.Round(imc, 2) + " e você está com Obesidade grau II(severa)!PROCURE UM MÉDICO!!!");
            } else
            {
                Console.WriteLine("Seu IMC é: " + Math.Round(imc, 2) + " e você está com Obesidade grau III(mórbida)!PROCURE UM MÉDICO!!!");
            }

            //Console.WriteLine("\n");
            Console.WriteLine("************************************************************************");
        }
    }
}
