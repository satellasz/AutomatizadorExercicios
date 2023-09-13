namespace AutomatizadorExercicios.Exercícios
{
    public partial class Exercicios
    {
        // 1) Peça ao usuário o valor de seu salário e dê o reajuste de 10%. Mostre o novo valor do salário.
        public void ReajusteSalarial()
        {
            Console.WriteLine("Exercício 1: Reajuste salarial");

            double novoSalario;
            const double reajuste = 10;

            Console.Write("Digite o seu salário R$: ");
            if (double.TryParse(Console.ReadLine(), out double salario))
            {
                novoSalario = salario + (salario * reajuste / 100);
                Console.WriteLine($"Com o reajuste de {reajuste}%, o novo salário vai ser de R$: {novoSalario}");
            }
            else
            {
                Console.WriteLine("Salário inválido");
            }
        }

        // 2) Peça o valor de venda de um produto e de um desconto de 5%. Mostre o valor final.
        public void DescontoProduto()
        {
            Console.WriteLine("Exercício 2: Desconto de um produto");

            double novoValorProd;
            const double desconto = 5;

            Console.Write("Digite o valor do produto: ");
            if (double.TryParse(Console.ReadLine(), out double valorProd))
            {
                novoValorProd = valorProd - (valorProd * desconto / 100);
                Console.WriteLine($"Com o desconto de {desconto}%, o novo valor do produto vai ser de R$: {novoValorProd}");
            }
            else
            {
                Console.WriteLine("Valor inválido");
            }
        }

        // 3) Peça a altura e o peso de uma pessoa e mostre o Índice de Massa Corporal desta pessoa. (IMC = razão entre o peso e o quadrado da altura)

        public void IMC()
        {
            Console.WriteLine("Exercício 3: Cálculo de IMC");

            double imc;

            Console.Write("Digite a sua altura: ");
            if (double.TryParse(Console.ReadLine(), out double altura))
            {
                Console.Write("Digite o seu peso: ");
                if (double.TryParse(Console.ReadLine(), out double peso))
                {
                    imc = peso / (Math.Pow(altura, 2));
                    Console.WriteLine($"Com a altura de {altura}m e pesando {peso}kg, o seu IMC é de: {imc:F}");
                }
                else
                {
                    Console.WriteLine("Altura inválida");
                }
            }
            else
            {
                Console.WriteLine("Peso inválida");
            }
        }

        // 4) Escreva um simulador de aplicações financeiras a juros simples. Peça o capital, o tempo de aplicação e a taxa de juros. Mostre o montante final e os juros mensais.   MONTANTE = CAPITALxPERIODOxJUROS
        public void JurosSimples()
        {
            Console.WriteLine("Exercício 4: Cálculo de juros simples");

            double montante, jurosMensais;

            Console.Write("Digite o seu capital R$: ");
            if (double.TryParse(Console.ReadLine(), out double capital))
            {
                Console.Write("Digite o tempo de aplicação (em meses): ");
                if (int.TryParse(Console.ReadLine(), out int tempoAplicado))
                {
                    Console.Write("Digite a taxa de juros: ");
                    if (double.TryParse(Console.ReadLine(), out double taxaJuros))
                    {
                        taxaJuros = taxaJuros / 100;
                        jurosMensais = capital * tempoAplicado * taxaJuros;
                        montante = jurosMensais + capital;
                        Console.WriteLine($"Com o capital de R${capital}, o tempo aplicado de {tempoAplicado} (meses) e taxa de juros de {taxaJuros}% ao mês, o montante final vai ser de R${montante}\nE os juros mensais serão de {jurosMensais / tempoAplicado:F}%");
                    }
                    else
                    {
                        Console.WriteLine("Taxa de juros inválida");
                    }
                }
                else
                {
                    Console.WriteLine("Tempo aplicado inválido");
                }
            }
            else
            {
                Console.WriteLine("Capital inválido");
            }
        }
    }
}
