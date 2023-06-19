using Classes;
namespace lista3

{
    public class Lista3
    {
        static void Main(string[] args)
        {

            int opcao;
            do
            {




                Console.WriteLine("Digite o número do exercicio você quer iniciar. --Ou digite -1 para sair");
                opcao = int.Parse(Console.ReadLine());

                lista3Classes lista3Classes = new lista3Classes();

                switch (opcao)
                {
                    case 1:

                        Console.WriteLine("A média é: " + lista3Classes.ESTOQUE());
                        break;

                    case 2:

                        Console.WriteLine(lista3Classes.CONVERSAO());
                        break;

                    case 3:
                        Console.WriteLine(lista3Classes.COMISSAO());
                        break;

                    case 4:
                        Console.WriteLine(lista3Classes.Distibutiva());
                        break;
                    case 5:
                        Console.WriteLine(lista3Classes.Velocidade());
                        break;
                    case 6:
                        lista3Classes.FahRenheit_Celsius();
                        break;
                    case 7:
                        Console.WriteLine(lista3Classes.Lata_D_Óleo());
                        break;
                    case 8:
                        Console.WriteLine(lista3Classes.idade());

                        break;
                    case 9:
                        Console.WriteLine(lista3Classes.numeros());

                        break;
                    case 10:
                        Console.WriteLine(lista3Classes.Troca_De_Valor());

                        break;
                    case 11:
                        Console.WriteLine(lista3Classes.modulo());

                        break;
                    case 12:
                        Console.WriteLine(lista3Classes.ordemD());

                        break;

                    case 13:
                        Console.WriteLine(lista3Classes.diferencaMaiorMenor());

                        break;

                    case 14:
                        Console.WriteLine(lista3Classes.NotasEscolares());

                        break;
                    case 15:
                        Console.WriteLine(lista3Classes.maiorMennor());

                        break;

                    case 16:
                        Console.WriteLine(lista3Classes.verificar9_0());

                        break;


                    case 17:
                        Console.WriteLine(lista3Classes.verificar1_3());

                        break;



                    case 18:
                        Console.WriteLine(lista3Classes.triangulo());

                        break;

                    case 19:
                        Console.WriteLine(lista3Classes.maiorQueZero());

                        break;


                    case 20:
                        lista3Classes.negativoOrPositivo ();

                        break;
                    case 21:
                        Console.WriteLine (lista3Classes.armazenamento ());

                        break;
                    case 22:
                        Console.WriteLine(lista3Classes.operacoes());

                        break;
                    case 23:
                        Console.WriteLine(lista3Classes.escolha_de_numeros_inteiros());

                        break;
                    case 24:
                        Console.WriteLine(lista3Classes.Peso_Ideal());

                        break;
                    case 25:
                        Console.WriteLine(lista3Classes.ordem_descrescente());

                        break;
                    case 26:
                        lista3Classes.fatorial();

                        break;
                        break;
                    case 27:
                        lista3Classes.impard100A200();

                        break;
                    case 28:
                        lista3Classes.numero0ate2000();

                        break;

                    case 29:
                        lista3Classes.tabuadaDasboa();

                        break;
                    case 30:
                        Console.WriteLine (lista3Classes.numerosPositivos());

                        break;
                    case 31:
                        Console.WriteLine(lista3Classes._20aoquadrado ());

                        break;
                        
                    case 32:
                        Console.WriteLine(lista3Classes.aluninhos());

                        break;
                    case 33:
                        Console.WriteLine(lista3Classes.menorNumero());

                        break;

                }
            } while (opcao != -1);
        }
    }
}
