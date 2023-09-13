using AutomatizadorExercicios.Exercícios;
using System.Reflection;

namespace AutomatizadorExercicios.Services
{
    public class ExerciciosServices
    {
        private static readonly Type tipo = typeof(Exercicios);
        private static readonly object? instancia = Activator.CreateInstance(tipo);

        private static void ChamarTodosMetodos()
        {
            var metodos = PegarTodosMetodos();

            for (int c = 1; c < metodos.Select(x => x.Name).ToList().Count; c++)
            {
                MethodInfo? metodo = tipo.GetMethod(metodos[c - 1].Name);

                if (metodo != null && HasParameters(c - 1))
                {
                    var parametros = SetParameters(c);
                    metodo.Invoke(instancia, parametros);
                }

                Console.WriteLine("--------------------------------");
            }
        }

        private static void ChamarUmMetodo(int id, object[] parameters)
        {
            MethodInfo metodo = PegarTodosMetodos()[id - 1];

            if (metodo != null)
            {
                metodo.Invoke(instancia, parameters);
            }
        }

        private static MethodInfo[] PegarTodosMetodos()
        {
            MethodInfo[] metodos = tipo.GetMethods(BindingFlags.Public
                                                  | BindingFlags.DeclaredOnly
                                                  | BindingFlags.Instance);

            return metodos;
        }

        private static object[] SetParameters(int id)
        {
            List<object> parametros = new();

            foreach (var parametro in GetParameters(id))
            {
                var tipoParam = parametro.ParameterType;

                Console.WriteLine($"Digite um parâmetro do tipo: {tipoParam.Name}");

                dynamic novoparametro;

                switch (tipoParam.ToString())
                {
                    case "System.Int32":
                        novoparametro = int.Parse(Console.ReadLine());
                        parametros.Add(novoparametro);
                        break;
                    case "System.String":
                        novoparametro = Console.ReadLine();
                        parametros.Add(novoparametro);
                        break;
                    case "System.Double":
                        novoparametro = double.Parse(Console.ReadLine());
                        parametros.Add(novoparametro);
                        break;
                }
            }

            return parametros.ToArray();
        }

        static bool HasParameters(int id)
        {
            var metodo = PegarTodosMetodos()[id - 1];

            return metodo.GetParameters() != null;
        }

        static ParameterInfo[] GetParameters(int id)
        {
            List<ParameterInfo> parametros = new();

            if (HasParameters(id))
            {
                foreach (var parametro in PegarTodosMetodos()[id - 1].GetParameters())
                {
                    parametros.Add(parametro);
                }
            }

            return parametros.ToArray();
        }
        private static void ListarMetodos()
        {
            MethodInfo[] metodos = PegarTodosMetodos();

            Console.WriteLine("Lista de métodos disponíveis: ");

            for (int c = 0; c < metodos.Length; c++)
            {
                Console.WriteLine($"{c + 1} - {metodos[c].Name}");
            }

            Console.WriteLine("--------------------------------");
        }

        public static void Controlador()
        {
            ListarMetodos();

            Console.Write("Digite:\n1 - Chamar todos os métodos\n2 - Chamar um método específico\n-> ");

            if (int.TryParse(Console.ReadLine(), out int input))
            {
                if (input == 1)
                {
                    Console.Clear();

                    ChamarTodosMetodos();
                }
                else if (input == 2)
                {
                    Console.WriteLine("--------------------------------");

                    int length = PegarTodosMetodos().Length;

                    Console.Write($"Digite um número entre {length - (length - 1)} e {length} para um escolher um método: ");
                    if (int.TryParse(Console.ReadLine(), out int id) && id <= length)
                    {
                        Console.WriteLine("--------------------------------");

                        var parametros = SetParameters(id);

                        ChamarUmMetodo(id, parametros);
                    }
                    else
                    {
                        Console.WriteLine("Número inválido");
                    }
                }
                else
                {
                    Console.WriteLine("Número inválido");
                }
            }
            else
            {
                Console.WriteLine("Número inválido");
            }

            Console.WriteLine("--------------------------------");

            Console.Write("Deseja continuar? [S/N]: ");
            if (char.TryParse(Console.ReadLine(), out char respostaContinuar))
            {
                if (respostaContinuar == 'S' || respostaContinuar == 's')
                {
                    Console.Clear();

                    Controlador();
                }
                else
                {
                    Console.WriteLine("Fechando o programa.");
                }
            }
        }
    }
}
