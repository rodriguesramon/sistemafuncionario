using System ;

namespace sistemafuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();

            Console.WriteLine("Nome Funcionario: ");
            funcionario.Nome = Console.ReadLine();

            Console.WriteLine("Salario Funcionario: ");
            funcionario.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Funcionario: {0} - Salario {1}", 
                              funcionario.Nome, funcionario.novoSalario());


        }
    }
}
