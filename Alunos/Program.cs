using System;

namespace Alunos
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[50];
            var indicealuno = 0;
            string opcao = ObterOpcao();

            while (opcao.ToUpper() != "X")
            {
                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Informe o nome do aluno: ");

                        Aluno aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();

                        Console.WriteLine();
                        Console.WriteLine("Informe a nota do aluno: ");

                        if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                            aluno.Nota = nota;
                            alunos[indicealuno] = aluno;
                            indicealuno++;

                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Digite uma nota válida");
                        }

                        break;
                    case "2":
                        foreach(var a in alunos)
                        {
                            if(a.Nome != null)
                                Console.WriteLine($"Aluno: {a.Nome} - Nota: {a.Nota}");
                        }

                        break;
                    case "3":
                        decimal notatotal = 0;
                        var nalunos = 0;
                        for(int i=0; i < alunos.Length; i++)
                        {
                            if(alunos[i].Nome != null)
                            {
                                notatotal = notatotal + alunos[i].Nota;
                                nalunos++;
                            }
                        }

                        var media = notatotal / nalunos;
                        Console.WriteLine($"A média geral é {media}");

                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

                Console.WriteLine();
                opcao = ObterOpcao();
            }
        }

        private static string ObterOpcao()
        {
            Console.WriteLine("Informe a opção desejada: ");
            Console.WriteLine("1- Inserir novo aluno");
            Console.WriteLine("2- Listar alunos");
            Console.WriteLine("3- Calcular média geral");
            Console.WriteLine("X- Sair ");
            Console.WriteLine();
            string opcao = Console.ReadLine();
            Console.WriteLine();

            return opcao;
        }
    }
}
