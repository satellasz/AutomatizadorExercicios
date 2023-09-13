namespace AutomatizadorExercicios.Exercícios
{
    public partial class Exercicios
    {
        // 5) Escreva um programa que peça um número qualquer ao usuário e depois informe se o número digitado é negativo, zero ou positivo.
        public void NegativoPositivo()
        {
            Console.WriteLine("Exercício 5: Negativo, zero ou positivo");

            Console.Write("Digite um número: ");
            if (double.TryParse(Console.ReadLine(), out double numeroInput))
            {
                if (numeroInput < 0)
                {
                    Console.WriteLine("O número informado é negativo");
                }
                else if (numeroInput == 0)
                {
                    Console.WriteLine("O número informado é zero");
                }
                else
                {
                    Console.WriteLine("O número informado é positivo");
                }
            }
            else
            {
                Console.WriteLine("Número inválido");
            }
        }

        // 6) Escreva um programa que verifique se o usuário é maior ou menor de idade.
        public void IdadeMaiorOuMenor()
        {
            Console.WriteLine("Exercício 6: Usuário menor ou maior de idade");

            Console.Write("Digite a sua idade: ");
            if (int.TryParse(Console.ReadLine(), out int idade))
            {
                if (idade < 18)
                {
                    Console.WriteLine("Usuário menor de idade");
                }
                else
                {
                    Console.WriteLine("Usuário maior de idade");
                }
            }
            else
            {
                Console.WriteLine("Idade inválida");
            }
        }

        // 7) Escreva um programa que leia um número inteiro positivo e diga se o mesmo é par ou ímpar.
        public void ParOuImpar()
        {
            Console.WriteLine("Exercício 7: Par ou ímpar");

            Console.Write("Digite um número inteiro positivo: ");
            if (int.TryParse(Console.ReadLine(), out int numeroInput))
            {
                if (numeroInput % 2 == 0)
                {
                    Console.WriteLine("O número é par");
                }
                else
                {
                    Console.WriteLine("O número é ímpar");
                }
            }
            else
            {
                Console.WriteLine("Número inválido");
            }
        }

        // 8) Escreva um programa que leia a nota parcial e exame e indique se o aluno foi aprova ou reprovado. Mostre é média final.
        public void AprovadoOuReprovado()
        {
            Console.WriteLine("Exercício 8: Aluno aprovado ou reprovado");

            double mediaFinal;

            Console.Write("Digite a nota da prova parcial: ");
            if (double.TryParse(Console.ReadLine(), out double notaParcial))
            {
                Console.Write("Digite a nota do exame: ");
                if (double.TryParse(Console.ReadLine(), out double notaExame))
                {
                    mediaFinal = (notaParcial + notaExame) / 2;
                    if (mediaFinal >= 5)
                    {
                        Console.WriteLine($"Com a nota final de {mediaFinal} aluno foi APROVADO");
                    }
                    else
                    {
                        Console.WriteLine($"Com a nota final de {mediaFinal} aluno foi REPROVADO");
                    }
                }
                else
                {
                    Console.WriteLine("Nota do exame inválida");
                }
            }
            else
            {
                Console.WriteLine("Nota parcial inválida");
            }
        }

        // 9) Escreva  uma calculadora simples que faça operações com dois números. As operações devem ser: Adição, Subtração, Multiplicação, Divisão (atenção nesta), elevar ao quadrado.
        public void Calculadora()
        {
            Console.WriteLine("Exercício 9: Calculadora simples");

            double resultado;

            Console.Write("Digite o primeiro número: ");
            if (double.TryParse(Console.ReadLine(), out double primeiroNumero))
            {
                Console.Write("Digite o segundo número: ");
                if (double.TryParse(Console.ReadLine(), out double segundoNumero))
                {
                    Console.Write("Digite o operador (+, -, *, /, ^): ");
                    if (char.TryParse(Console.ReadLine(), out char operador))
                    {
                        if (operador == '+')
                        {
                            resultado = primeiroNumero + segundoNumero;
                            Console.WriteLine($"{primeiroNumero} + {segundoNumero} = {resultado}");
                        }
                        else if (operador == '-')
                        {
                            resultado = primeiroNumero - segundoNumero;
                            Console.WriteLine($"{primeiroNumero} - {segundoNumero} = {resultado}");
                        }
                        else if (operador == '*')
                        {
                            resultado = primeiroNumero * segundoNumero;
                            Console.WriteLine($"{primeiroNumero} * {segundoNumero} = {resultado}");
                        }
                        else if (operador == '/')
                        {
                            resultado = primeiroNumero / segundoNumero;
                            Console.WriteLine($"{primeiroNumero} / {segundoNumero} = {resultado}");
                        }
                        else if (operador == '^')
                        {
                            resultado = Math.Pow(primeiroNumero, 2);
                            Console.WriteLine($"{primeiroNumero} ^ 2 = {resultado}");
                            resultado = Math.Pow(segundoNumero, 2);
                            Console.WriteLine($"{segundoNumero} ^ 2 = {resultado}");
                        }
                        else
                        {
                            Console.WriteLine("Operador inválido");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Operador inválido");
                    }
                }
                else
                {
                    Console.WriteLine("Segundo número é inválido");
                }
            }
            else
            {
                Console.WriteLine("Primeiro número é inválido");
            }
        }
    }
}
