using System;
//using é uma forma de importação  mesma coisa do import!
//Não é obrigatório

//1- namespace é obrigatório esse é o nome do meu pacote
namespace Primeiraaulacsharp
{
    /*
    Regras:
    1-Só ter uma Classe;
    2-Toda classe tem que ser inscrita em pascal case
    */
    class Program
    {
        //O primeiro metodo a ser executado.
        static void Main(string[] args)
        {
            string option;
            do 
            {
            showDialog();
            Console.WriteLine("Deseja continuar? SIM/NAO");
            option = Console.ReadLine();
            } while(option.Equals("SIM") || option.Equals("Sim") || option.Equals("sim"));
            
           
        }
        /*
        Tipos de dados:
        String ou string = textos, sempre com ""(aspas duplas)
        Int ou int = numeros inteiros(1 10 20 99)
        boolean ou boo = valores Lógicos(true ou false);
        Double ou double = valores decimais(1.5 2.7 50.99)
        DateTime = valor para trabalhar com data e hora
        */

        static int calculate(int number1, int number2, int operation)
        {
            int result;
            switch (operation)
            {
                case 1:
                    result = number1 + number2;
                    break;
                case 2:
                    result = number1 - number2;
                    break;
                case 3: 
                    result = number1 * number2;
                    break;
                case 4:
                    if(number1.Equals(0) || number2.Equals(0)){
                        result = 0;
                    } else {
                    result = number2 / number1;
                    }
                    break;
                case 5:
                    if(number1.Equals(0) || number2.Equals(0)){
                        result = 0;
                    } else {
                    result = number2 % number1;
                    }
                    break;
                default:
                    result = 0;
                    break;

            }

            if(!result.Equals(null)){
                return result;
            }
            return 0;

        }

        static void showDialog() 
        {
            string name;
            int number1;
            int number2;
            int operation;
            DateTime data = DateTime.Now;
            Console.WriteLine("Digite seu nome: ");
            name = Console.ReadLine();
            Console.WriteLine("Seja Bem vindo {0}, Por favor escolha um número", name);
            number1 = verifyNullNumber(Console.ReadLine());
            Console.WriteLine("Perfeito o primeiro número é: {0}, por favor digite o próximo", number1);
            number2 = verifyNullNumber(Console.ReadLine());
            Console.WriteLine("Agora escolha uma operação: ");
            Console.WriteLine("1-Somar(código 1)");
            Console.WriteLine("2-Subtrair(código 2)");
            Console.WriteLine("3-Multiplicar(código 3)");
            Console.WriteLine("4-Dividir(código 4)");
            Console.WriteLine("5-Resto da divisão(código 5)");
            operation = verifyNullNumber(Console.ReadLine());
            Console.WriteLine("O resultado é: {0}", calculate(number1, number2, operation));
            Console.WriteLine("fim da execução {0}", data);
        }
        
    static int verifyNullNumber(string number)
    {
        if(number.Equals("")){
            return 0;
        }
        return int.Parse(number);
        
    }
    }

}
