using System.Collections;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Classes
{
    public class lista3Classes
    {
        public double ESTOQUE()
        {
            Console.WriteLine("Digite a quantidade mínima de estoque");
            int Min = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade Máxima de estoque");
            int Max = int.Parse(Console.ReadLine());

            return (Min + Max) / 2;

        }

        public string CONVERSAO()
        {

            Console.WriteLine("Digite um valor em dólares");
            decimal Dolar = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Digite a cotação do dolar atual");
            decimal Cot = decimal.Parse(Console.ReadLine());

            return ("A cotação atual do Dolar é: " + Cot + "\n O valor ditiado foi: " + Dolar + " $ \n A conversão desse valor para real é de " + (Dolar * Cot) + " R$");
        }

        public string COMISSAO()
        {

            Console.WriteLine("---------TABELA DE PREÇOS---------\n" +
            "CARBURADOR--COD 1--PRECO R$ 5000" +
            "\nMOTOR --COD 2 --PRECO R$ 10000" +
            "\nRETROVIOR --COD 3 --PRECO R$ 300");

            Console.WriteLine("Nome do vendedor: ");
            string Nome = Console.ReadLine();


            int valor = 1;
            var totitems = 0;
            ArrayList ar = new ArrayList();

            for (int i = 0; i < valor; i++)
            {
                var codP = 0;
                Console.WriteLine("Digite o código da peça que você vendeu ou digite -1 para parar de cadastrar peças");

                codP = int.Parse(Console.ReadLine());

                if (codP == -1) break;
                if (codP < 1 || codP > 3)
                {
                    var analise = 0;
                    do
                    {


                        int[] verificar = new int[] { 1, 2, 3 };

                        Console.WriteLine("Valor incorreto, corrija: ");
                        codP = int.Parse(Console.ReadLine());

                        foreach (int a in verificar)
                        {
                            if (a == codP)
                            {
                                analise = codP;

                                break;
                            }
                            else
                            {
                                analise = 30;
                            }
                        }


                    } while (codP != analise);
                }
                totitems++;
                if (codP == 1) ar.Add(5000);
                if (codP == 2) ar.Add(10000);
                if (codP == 3) ar.Add(300);
                valor++;

            }
            var valortot = 0;
            foreach (int item in ar)
            {
                valortot += item;
            }

            return "Nome: " + Nome + "\n Valor total das peças vendidas: " + valortot +
               "\n Total de peças vendidas: " + totitems + "\n Valor total da comissão que o vendedor irá receber é de 5%: " + (valortot * 5) / 100;


        }
        public int Distibutiva()
        {

            int[] arr = new int[4];

            var valorTot = 0;
            do
            {
                Console.WriteLine("Digite um numero ");
                arr[valorTot] = int.Parse(Console.ReadLine());
                valorTot++;
            } while (valorTot < 4);


            var result1 = 0;
            var result2 = 0;
            var result3 = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                result1 = arr[0] * arr[1] * arr[0] * arr[2] * arr[0] * arr[3] + (arr[0] + arr[1] + arr[0] + arr[2] + arr[0] + arr[3]);
                result2 = arr[1] * arr[2] * arr[1] * arr[3] + (arr[1] + arr[2] + arr[1] + arr[3]);
                result3 = arr[2] * arr[3] + (arr[2] + arr[3]);

            }
            return result1 + result2 + result3;
        }
        public string Velocidade()
        {

            Console.WriteLine("Digite o tempo gasto na viagem: ");
            int Tempo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a velocidade média na viagem: ");
            int MédiaVelo = int.Parse(Console.ReadLine());


            int DISTANCIA = Tempo * MédiaVelo;

            Console.WriteLine("Digite quantos km por litro o seu carro faz");
            int KMPORLITRO = int.Parse(Console.ReadLine());

            int LITROS_USADOS = DISTANCIA / KMPORLITRO;

            return ("A velocidade média foi de:  " + MédiaVelo + "\n O tempo gasto foi de: " + Tempo + " Horas \n  A DISTÂNCIA PERCORRIDA FOI DE: " + DISTANCIA + "\n A quantidade de litros gastos foi de: " + LITROS_USADOS + "L");

        }
        public void FahRenheit_Celsius()
        {

            var Opcao = "";
            do
            {
                Console.WriteLine("Digite C para ler uma temperatura em Celsius e converter para Fahrenheit  \n" +
            "Digite F para ler uma temperatura em Fahrenheit e converter para Celsius \n Digite S para finalizar");

                Opcao = Console.ReadLine().ToUpper();


                if (Opcao == "C")
                {
                    Console.WriteLine("Digite a temperatura em Celsius: ");
                    decimal C = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("A temperatura em fahrenheit é:  " + (9 * C + 160) / 5 + " F");
                }
                if (Opcao == "F")
                {
                    Console.WriteLine("Digite a temperatura em Fahrenheit: ");
                    decimal F = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("A temperatura em Celsius é: " + (F - 32) * 5 / 9 + " C ");
                }
            } while (Opcao != "S");



        }
        public string Lata_D_Óleo()
        {

            Console.WriteLine("Digite o raio: ");
            double Raio = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura: ");
            double Altura = double.Parse(Console.ReadLine());



            return "O volume é: " + (3.14159 * Raio * Raio * Altura);
        }

        public string idade()
        {
            Console.WriteLine("Escreva quantos anos você tem: ");
            int anos = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva quantos meses você tem: ");
            int meses = int.Parse(Console.ReadLine());
            if (meses > 12 || meses < 1) return "Erro, os meses não podem ser maior do que 12 e nem menor do que 1";
            Console.WriteLine("Escreva quantos dias você tem: ");
            int dias = int.Parse(Console.ReadLine());
            if (dias > 30 || dias < 1) return "Erro, os dias não podem ser maior do que 30 ou menor do que 1";
            int result = (anos * 365) + (meses * 30) + dias;

            return "Sua idade em dias é: " + result;
        }
        public string numeros()
        {
            Console.WriteLine("Digite o valor do número 1: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do número 2: ");
            int n2 = int.Parse(Console.ReadLine());

            var resultado = "";
            if (n1 == n2) resultado += "Os numeros são iguais \n";
            if (n1 != n2) resultado += "Os números não são iguais \n";
            if (n1 > n2) resultado += n1 + " é o maior numero \n";
            if (n2 > n1) resultado += n2 + " é o maior numero \n";
            if (n1 < n2) resultado += n1 + " é o menor número \n";
            if (n1 >= n2) resultado += n1 + " É maior ou igual a " + n2 + "\n";
            if (n2 >= n1) resultado += n2 + " é maior ou igual a " + n1 + "\n";
            if (n1 <= n2) resultado += n1 + " é menor ou igual a " + n2 + "\n";
            if (n2 <= n1) resultado += n2 + " é menor ou igual a " + n1 + "\n";

            return resultado;
        }


        public string Troca_De_Valor()
        {
            Console.WriteLine("Digite o valor de A");
            int A = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de B");
            int B = int.Parse(Console.ReadLine());

            int newValue = A;
            newValue = B;
            B = A;


            return "Valor de A: " + newValue + " Valor de B: " + B;
        }
        public string modulo()
        {
            Console.WriteLine("Digite um número");
            int Numero = int.Parse(Console.ReadLine());




            if (Numero < 0) return "O módulo de " + Numero + " é " + Numero * (-1);

            return "O módulo de " + Numero + " é " + Numero;
        }

        public string ordemD()
        {
            int[] arr = new int[3];

            int contador = 0;
            do
            {
                Console.WriteLine("Digite um número");

                arr[contador] = int.Parse(Console.ReadLine());
                contador++;
            } while (contador != 3);

            Array.Sort(arr);
            Array.Reverse(arr);

            string resultado = "";
            foreach (int numero in arr)
            {
                resultado += numero + "\n";
            }

            return "Números em ordem decrescente: \n" + resultado;
        }

        public string diferencaMaiorMenor()
        {
            Console.WriteLine("Digite o primeiro número");
            int Numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro número");
            int Numero2 = int.Parse(Console.ReadLine());

            int resultado = 0;
            if (Numero1 > Numero2)
            {
                resultado = Numero1 - Numero2;
            }
            if (Numero1 < Numero2)
            {
                resultado = Numero2 - Numero1;
            }

            if (Numero1 == Numero2)
            {
                resultado = 0;
            }

            return "A diferença de " + Numero1 + " Para o número " + Numero2 + " é " + resultado;
        }

        public string NotasEscolares()
        {
            double[] arr = new double[4];

            int contador = 0;
            do
            {
                Console.WriteLine("Digite uma nota");

                arr[contador] = double.Parse(Console.ReadLine());
                contador++;
            } while (contador != 4);


            double media = (arr[0] + arr[1] + arr[2] + arr[3]) / 4;

            Console.WriteLine("Sua média é: " + media);

            if (media < 7)
            {
                Console.WriteLine("Você está de recuperação");
                Console.WriteLine("Digite a nota de recuperação: ");
                double NotaRec = double.Parse(Console.ReadLine());

                double NovMedia = (NotaRec + media) / 2;

                if (NovMedia < 7)
                {
                    return "Você atingiu a média de " + NovMedia + " E está reprovado";
                }
                if (NovMedia >= 7)
                {
                    return "Você atingiu a média de " + NovMedia + " E está aprovado";
                }

            }



            return "Você atingiu a média de " + media + " E está aprovado";


        }


        public string maiorMennor()
        {
            Console.WriteLine("Digite um número");
            int Numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro número");
            int Numero2 = int.Parse(Console.ReadLine());


            int Maior = 0;
            int Menor = 0;
            if (Numero1 > Numero2)
            {
                Maior = Numero1;
                Menor = Numero2;
            }
            if (Numero2 > Numero1)
            {
                Maior = Numero2;
                Menor = Numero1;
            }
            if (Numero1 == Numero2)
            {
                return "Os números são iguais";
            }

            return "O maior número é: " + Maior + " E o menor número é: " + Menor;
        }

        public string verificar9_0()
        {
            Console.WriteLine("Digite um número");
            int Numero = int.Parse(Console.ReadLine());

            if (Numero < 0 || Numero > 9) return "Valor inválido";

            return "Valor válido";

        }
        public string verificar1_3()
        {
            Console.WriteLine("Digite um número");
            int Numero = int.Parse(Console.ReadLine());

            switch (Numero)
            {
                case 1:
                    return "um";
                case 2:
                    return "dois";
                case 3:
                    return "tres";

                default:
                    return "Numero inválido";
            }

        }
        public string triangulo()
        {
            Console.WriteLine("Digite o valor do lado A: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do lado B: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do lado C: ");
            int c = int.Parse(Console.ReadLine());

            string resultado = "";
            if (a < b + c && b < a + c && c < a + b)
            {
                if (a == b && b == c)
                {
                    resultado = ("Triângulo equilátero");
                }
                else if (a == b || a == c || b == c)
                {
                    resultado = ("Triângulo isósceles");
                }
                else
                {
                    resultado = ("Triângulo escaleno");
                }
            }
            else
            {
                resultado = ("Os valores informados não formam um triângulo.");

            }
            return resultado;

        }

        public string maiorQueZero()
        {
            int[] arr = new int[3];
            int parar = 0;
            int valor = 0;
            do
            {
                Console.WriteLine("Digite o valor " + parar);
                valor = int.Parse(Console.ReadLine());
                if (valor < 0)
                {

                    do
                    {

                        Console.WriteLine("Digite novamente: ");
                        valor = int.Parse(Console.ReadLine());
                    } while (valor <= 0);
                }

                arr[parar] = valor;
                parar++;
            } while (parar != 3);



            Array.Sort(arr);

            return "O menor valor é: " + arr[0] + "\n" +
                "O maior valor é: " + arr[2] + "\n" +
            "Multiplicação do menor valor (" + arr[0] + ") " + "Com o  maior valor: (" + arr[2] + ")" + "\n" +
                "Resultado: " + arr[0] * arr[2] + "\n" +
                "Dividindo do maior valor (" + arr[2] + ") " + "Com o  menor valor: (" + arr[0] + ")" + "\n" +
                "Resultado: " + arr[2] / arr[0];

        }

        public void negativoOrPositivo()
        {

            int parar = 0;
            string resultado = "";
            do
            {

                Console.WriteLine("Digite um número: ");
                parar = int.Parse(Console.ReadLine());


                if (parar >= 0) resultado = "positivo";
                if (parar < 0) resultado = "negativo";
                if (parar != -1) Console.WriteLine("O número que voce digitou é: " + resultado);
            } while (parar != -1);
        }

        public string armazenamento()
        {


            ArrayList A = new ArrayList();
            ArrayList B = new ArrayList();


            int stop = 0;

            do
            {

                Console.WriteLine("Digite um número");
                stop = int.Parse(Console.ReadLine());




                if (stop >= 0)
                {

                    A.Add(stop);
                };



                if (stop < 0)
                {
                    B.Add(stop);
                };





            } while (stop != -1);

            string Positivos = "";
            string Negativos = "";
            foreach (int i in A)
            {
                Positivos += i.ToString() + "\n";
            }
            foreach (int i in B)
            {
                Negativos += i.ToString() + "\n";

            }

            return "Números positivos: " + Positivos + "\n" +
            "Números Negativos: " + Negativos + "\n";
        }
        public string operacoes()
        {

            Console.WriteLine("Digite  1 para Adição, 2 para Subtração, 3 para Multiplicação, 4 para Divisisão");
            int operacao = int.Parse(Console.ReadLine());

            if (operacao < 1 || operacao > 3) return "erro";
            Console.WriteLine("Valor 1");
            int valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor 2");
            int valor2 = int.Parse(Console.ReadLine());

            double resultado = 0;
            switch (operacao)
            {
                case 1:


                    resultado = valor1 + valor2;
                    break;

                case 2:
                    resultado = valor1 - valor2;
                    break;

                case 3:
                    resultado = valor1 * valor2;
                    break;
                case 4:


                    resultado = valor1 / valor2;
                    break;
            }
            return "resultado: " + resultado;
        }


        public string escolha_de_numeros_inteiros()
        {
            Console.WriteLine("Digite um número");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro número");
            int numero2 = int.Parse(Console.ReadLine());

            int Valor = 0;
            do
            {

                Console.WriteLine("Digite 1 para Verificar se um dos números lidos é ou não multiplo do outro" + "\n" +
                "Digite 2 para Verificar se os dois números lidos são pares" + "\n" +
                "Digite 3 para Verificar se  a média dos dois números é igual ou maior que 7" + "\n" +
                "Digite 4 para parar");
                Valor = int.Parse(Console.ReadLine());



                switch (Valor)
                {
                    case 1:
                        bool ao = false;
                        for (int i = 0; i <= 10; i++)
                        {
                            int resultado = numero1 * i;

                            if (resultado == numero2)
                            {

                                ao = true;
                                break;
                            }

                        }
                        if (ao)
                        {
                            Console.WriteLine(numero2 + " é multiplo de: " + numero1);
                        }
                        if (!ao) Console.WriteLine(numero2 + " não é multiplo de: " + numero1);
                        break;
                    case 2:
                        string valor1 = "";
                        string valor2 = "";
                        int resto1 = numero1 % 2;
                        int resto2 = numero2 & 2;

                        if (resto1 == 0) valor1 = "par";
                        if (resto1 == 1) valor1 = "impar";

                        if (resto2 == 0) valor2 = "par";
                        if (resto2 == 1) valor2 = "impar";
                        Console.WriteLine("O número:  " + numero1 + " é: " + valor1 + " e o número: " + numero2 + " é: " + valor2);
                        break;

                    case 3:
                        double media = numero1 / numero2;

                        if (media >= 7) Console.WriteLine("A média é: " + media + " e é maior ou igual a 7");
                        if (media < 7) Console.WriteLine("A média é: " + media + " e não é maior ou igual a 7");
                        break;
                }

            } while (Valor != 4);
            return "";

        }

        public string Peso_Ideal()
        {


            Console.WriteLine("Digite a sua altura: ");
            decimal altura = decimal.Parse(Console.ReadLine());


            Console.WriteLine("SEXO \n" + "Digite M para Masculino ou F para feminino");
            string sexo = Console.ReadLine().ToUpper();
            decimal resultado = 0;
            switch (sexo)
            {
                case "M":
                    resultado = (72.7m * altura) - 58m;
                    break;

                case "F":
                    resultado = (62.1m * altura) - 44.7m;
                    break;

                default:
                    return "Valor inválido";


            }

            return "o seu peso ideal é: " + resultado + "KG";

        }

        public string ordem_descrescente()
        {
            int[] arr = new int[101];

            for (int i = 0; i <= 100; i++)
            {
                arr[i] = i;
            }

            Array.Reverse(arr);

            string resultado = "";

            foreach (int i in arr)
            {
                resultado += i + " ";

            }
            return resultado;

        }
        public void fatorial()
        {
            Console.Write("Digite a quantidade de números a serem processados: ");
            int quantidade = int.Parse(Console.ReadLine());

            for (int i = 1; i <= quantidade; i++)
            {
                Console.Write($"Digite o número {i}: ");
                int numero = int.Parse(Console.ReadLine());

                long fatorial = CalcularFatorial(numero);

                Console.WriteLine($"O fatorial de {numero} é: {fatorial}\n");
            }
        }

        static long CalcularFatorial(int numero)
        {
            long fatorial = 1;

            for (int i = 1; i <= numero; i++)
            {
                fatorial *= i;
            }

            return fatorial;
        }
        public string impard100A200()
        {
            string resultado = "";
            for (int i = 100; i <= 200; i++)
            {
                if (i % 2 == 1) { resultado += i + " "; }

            }
            Console.WriteLine(resultado);
            return resultado;
        }

        public string numero0ate2000()
        {
            string resultado = "";
            for (int i = 0; i <= 2000; i++)
            {
                resultado += i + " ";

            }
            Console.WriteLine(resultado);
            return resultado;
        }

        public string tabuadaDasboa()
        {
            Console.WriteLine("Digite um numero: ");
            int numero = int.Parse(Console.ReadLine());

            string resultado = "";
            for (int i = 1; i <= 10; i++)
            {
                resultado += numero + " " + "X " + i + "= " + numero * i + "\n";

            }
            Console.WriteLine(resultado);
            return resultado;
        }


        public string numerosPositivos()
        {
            int opcao = 0;

            ArrayList arr = new ArrayList();
            do
            {
                Console.WriteLine("Digite numeros positivos ou qualquer numero negativo para encerrar");

                opcao = int.Parse(Console.ReadLine());

                if (opcao > 0) arr.Add(opcao);


            } while (opcao > 0);

            int pares = 0;
            int impares = 0;
            foreach (int a in arr)
            {

                if (a % 2 == 0)
                {
                    Console.WriteLine(a + "é par" + "\n");
                    pares += a;

                }
                if (a % 2 == 1)
                {
                    Console.WriteLine(a + "é impar" + "\n");
                    impares += a;

                }

            }


            return $"Soma dos numeros impares: {impares} \n Soma dos numeros pares:   {pares}";

        }
        public string _20aoquadrado()
        {

            Console.Write("Digite um número menor que 10 e maior que zero: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero > 0 && numero < 10)
            {
                int contador = 0;
                int somaQuadrados = 0;
                int numeroAtual = numero;

                while (contador < 20)
                {


                    if (numeroAtual % 2 != 0)
                    {
                        somaQuadrados += numeroAtual * numeroAtual;
                        contador++;
                    }

                    numeroAtual++;
                }

                Console.WriteLine("A soma dos quadrados dos 20 primeiros números ímpares é: " + somaQuadrados);
            }
            else
            {
                Console.WriteLine("O número informado não está dentro do intervalo válido.");
            }

            Console.ReadLine();
            return "";

        }

        class Alunos
        {
            public string Nome;
            public int Matricula;
            public int Nota;
            public int Media;
            public string status;
        }
        public string aluninhos()
        {

            Alunos alunos = new Alunos();
            ArrayList Alunor = new ArrayList();

            string stop = "";
            do
            {
                Console.WriteLine("Digite o nome do aluno: ");
                alunos.Nome = Console.ReadLine();
                Console.WriteLine("Digite a Matricula");
                alunos.Matricula = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite a nota; ");
                alunos.Nota = int.Parse(Console.ReadLine());

                alunos.Media = 60;
                if (alunos.Nota >= alunos.Media) alunos.status = "Aprovado";
                if (alunos.Nota < alunos.Media) alunos.status = "Reprovado";
                Alunor.Add(alunos);
                Console.WriteLine("Deseja finalizar? S/N");
                stop = Console.ReadLine().ToUpper();


            } while (stop != "S");
            int MatriculaNumero = 0;
            do
            {


                Console.WriteLine("Digite o numero da matricula do Aluno ou -1 para finalizar ");
                MatriculaNumero = int.Parse(Console.ReadLine());
                foreach (Alunos alunoss in Alunor)
                {

                    if (alunoss.Matricula.Equals(MatriculaNumero))
                    {
                        return ("Numero da Matricula: " + alunoss.Matricula + "\n" +
                       "Nome: " + alunoss.Nome + "\n" +
                       "Nota: " + alunoss.Nota + "\n" +
                       "Média da prova: " + alunoss.Media + "\n" +
                       "Status: " + alunoss.status);
                    }
                }
            } while (MatriculaNumero != -1);
            return "";
        }

        public string menorNumero()
        {
            ArrayList numeros = new ArrayList();
            int stop = 0;
            do
            {
                Console.WriteLine("Digite um numero inteiro Positivo ou -1 para finalizar");
                stop = int.Parse(Console.ReadLine());

                if (stop >= 0) numeros.Add(stop);

            } while (stop != -1);



            int[] NovoArr = (int[])numeros.ToArray(typeof(int));

            Array.Sort(NovoArr);


            return $"O maior numero é:  {NovoArr[NovoArr.Length - 1]}  \n O menor numero é: {NovoArr[0]} ";
        }

        public string _0a100()
        {
            ArrayList multiplosde10 = new ArrayList();

            for (int i = 1; i <= 10; i++)
            {
                multiplosde10.Add(10 * i);

            }
            for (int i = 1; i <= 100; i++)
            {
                if (multiplosde10.Contains(i)) {
                    Console.WriteLine(i + " é multiplo de 10");
                }
            }

            return "";

        }

        public string _10valoresinteiorspositivos()
        {


            int[] Valores = new int[10];
            int controle = 0;
            do
            {
                Console.WriteLine("Digite um valor inteiro positivo");

                Valores[controle] = int.Parse(Console.ReadLine());
                controle++;

            } while (controle != 10);


            Array.Sort(Valores);

            int result = 0;
            do
            {



                Console.WriteLine($"---TABELA---" + "\n" +
                "1 para maior valor" + "\n" +
                "2 para o menor valor" + "\n" +
                "3 para a média dos valores" + "\n" +
                "4 para finalizar");
                result = int.Parse(Console.ReadLine());
                Console.Clear();

                if (result == 1) Console.WriteLine("o maior valor é: " + Valores[Valores.Length - 1]);


                if (result == 2) Console.WriteLine("O menor valor é: " + Valores[0]);

                if (result == 3)
                {

                    int somaTot = 0;
                    foreach (int valores in Valores)
                    {
                        somaTot += valores;
                    }

                    Console.WriteLine("A média dos valores é: " + (somaTot / 10));
                }
            } while (result != 4);
            return "";

        }

        public string TabelaDeCalculos()
        {
            string opcao = "";
            int[] valores = new int[2];
            void agilizadora()
            {

                Console.WriteLine("Informe o valor A");
                valores[0] = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe o valor B");
                valores[1] = int.Parse(Console.ReadLine());
            }
            do
            {
                Console.WriteLine("Operações básicas:" + "\n" +
                "---------------------" + "\n" +
                "| Operação  " + "\n" +
                "|-------------|---------------|" + "\n" +
                "| 1 Adição     |" + "\n" +
                "| 2 Subtração |" + "\n" +
                "| 3 Multiplicação|" + "\n" +
                "| 4 Divisão  |" + "\n" +
                "---------------------");
                int operacao = int.Parse(Console.ReadLine());



                if (operacao == 1)
                {

                    agilizadora();
                    Console.WriteLine("A soma é: " + (valores[0] + valores[1]));
                }
                if (operacao == 2)
                {
                    agilizadora();
                    Console.WriteLine("A subtração é: " + (valores[0] - valores[1]));
                }
                if (operacao == 3)
                {
                    agilizadora();
                    Console.WriteLine("A Multiplicação é: " + (valores[0] * valores[1]));
                }
                if (operacao == 4)
                {
                    agilizadora();
                    Console.WriteLine("A divisão é: " + (valores[0] / valores[1]));
                }

                Console.WriteLine("Deseja finalizar? S/N");
                opcao = Console.ReadLine().ToUpper();

                Console.Clear();
            } while (opcao != "S");
            return "";


        }
        public string trabalho()
        {
            string encerrarPrograma = "N";

            while (encerrarPrograma != "S")
            {
                Console.Write("Digite o código do operário: ");
                int codigo = int.Parse(Console.ReadLine());

                Console.Write("Digite o número de horas trabalhadas: ");
                int horasTrabalhadas = int.Parse(Console.ReadLine());

                double salarioPorHora = 10.00;
                double salarioExcedente = 0.00;

                if (horasTrabalhadas > 50)
                {
                    int horasExcedentes = horasTrabalhadas - 50;
                    salarioExcedente = horasExcedentes * 20.00;
                    horasTrabalhadas -= horasExcedentes;
                }

                double salarioTotal = horasTrabalhadas * salarioPorHora;

                Console.WriteLine("Salário total: R$ " + salarioTotal.ToString("F2"));
                Console.WriteLine("Salário excedente: R$ " + salarioExcedente.ToString("F2"));

                Console.Write("Deseja encerrar o programa? (S/N): ");
                encerrarPrograma = Console.ReadLine().ToUpper();
                Console.WriteLine("\n");

            }
            return "";
        }
        public string numeropositivo()
        {
            string encerrarPrograma = "N";

            while (encerrarPrograma != "S")
            {
                Console.Write("Digite um número inteiro: ");
                int numero = Convert.ToInt32(Console.ReadLine());

                if (numero % 2 == 0)
                {
                    Console.WriteLine("O número é par.");
                }
                else
                {
                    Console.WriteLine("O número é ímpar.");
                }


                if (numero >= 0)
                {
                    Console.WriteLine("O número é positivo.");
                }
                else
                {
                    Console.WriteLine("O número é negativo.");
                }

                Console.Write("Deseja encerrar o programa? (S/N): ");
                encerrarPrograma = Console.ReadLine().ToUpper();
                Console.WriteLine();
            }
            return "";
        }

        public string poluicao ()
        {
            string encerrarPrograma = "N";

            while (encerrarPrograma != "S")
            {
                Console.Write("Digite o índice de poluição medido: ");
                double indicePoluicao = double.Parse(Console.ReadLine());

                if (indicePoluicao >= 0.5)
                {
                    Console.WriteLine("Todos os grupos devem paralisar suas atividades.");
                }
                else if (indicePoluicao >= 0.4)
                {
                    Console.WriteLine("Indústrias do 1o e 2o grupo devem suspender suas atividades.");
                }
                else if (indicePoluicao >= 0.3)
                {
                    Console.WriteLine("Indústrias do 1o grupo devem suspender suas atividades.");
                }
                else
                {
                    Console.WriteLine("Índice de poluição aceitável.");
                }

                Console.Write("Deseja encerrar o programa? (S/N): ");
                encerrarPrograma = Console.ReadLine().ToUpper();
                Console.WriteLine();
            }
            return "";
        }
    }

}
