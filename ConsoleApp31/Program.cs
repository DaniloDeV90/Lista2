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
                    case 34:
                        Console.WriteLine(lista3Classes._0a100());

                        break;
                    case 35:
                        Console.WriteLine(lista3Classes._10valoresinteiorspositivos());

                        break;
                    case 36:
                        Console.WriteLine(lista3Classes.TabelaDeCalculos());

                        break;
                    case 37:
                        Console.WriteLine(lista3Classes.trabalho());

                        break;
                    case 38:
                        Console.WriteLine(lista3Classes.numeropositivo());

                        break;
                    case 39:
                        Console.WriteLine(lista3Classes.poluicao());

                        break;
                    case 40:
                        Console.WriteLine(lista3Classes.nadador());

                        break;
                    case 41:
                        Console.WriteLine(lista3Classes.maximovalor());

                        break;
                    case 42:
                        Console.WriteLine(lista3Classes.graos());

                        break;
                    case 43:
                        Console.WriteLine(lista3Classes.altura_graus());

                        break;
                    case 44:
                        Console.WriteLine(lista3Classes.vetores());

                        break;
                    case 45:
                        Console.WriteLine(lista3Classes.acabapeloAmorDeDeus());

                        break;
                    case 46:
                        Console.WriteLine(lista3Classes.acabaPeloAmorDeDeus2());

                        break;
                    case 47:
                        Console.WriteLine(lista3Classes.mofi3());

                        break;
                    case 48:
                        Console.WriteLine(lista3Classes.acaba());

                        break;
                    case 49:
                        Console.WriteLine(lista3Classes.mofi34());

                        break;
                    case 50:
                        Console.WriteLine(lista3Classes.asd());

                        break;
                    case 51:
                        Console.WriteLine(lista3Classes.wejhs());

                        break;
                    case 52:
                        Console.WriteLine(lista3Classes.exer51());

                        break;
                    case 53:
                        Console.WriteLine(lista3Classes.exer52());

                        break;
                    case 54:
                        Console.WriteLine(lista3Classes.exer53());

                        break;
                    case 55:
                        Console.WriteLine(lista3Classes.exer54());

                        break;
                    case 56:
                        Console.WriteLine(lista3Classes.exer55());

                        break;
                }
            } while (opcao != -1);
        }
    }
}
