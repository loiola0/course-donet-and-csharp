using System;

namespace Revision
{
    class Program
    {

        private static string Menu(){
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1- Inserir novo aluno");
            Console.WriteLine("2- Listar alunos");
            Console.WriteLine("3- Calcular médial geral");
            Console.WriteLine("X- Sair");
            Console.WriteLine("");

            string opcaoUser = Console.ReadLine();
            
            return opcaoUser;
        }
        static void Main(string[] args)
        {
            string opcaoUser = Menu();
            Aluno[] alunos = new Aluno[5];
            var indiceAluno = 0;

            while(opcaoUser.ToUpper() != "X"){
                switch(opcaoUser){
                    case "1":
                        Console.WriteLine("Informe o nome do aluno:");
                        Aluno aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();

                        Console.WriteLine("Informe o nome do aluno:");

                        if(decimal.TryParse(Console.ReadLine(),out decimal nota)){
                            aluno.Nota = nota;
                        }else{
                            throw new ArgumentException("O valor digitado dever ser decimal");
                        }

                        alunos[indiceAluno] = aluno;
                        
                        indiceAluno++;
                        break;
                    case "2":
                        foreach(var a in alunos){
                            if(!string.IsNullOrEmpty(a.Nome)){
                                Console.WriteLine($"Aluno: {a.Nome} - Nota: {a.Nota}");
                            }
                                
                        }
                        break;
                    case "3":
                        //TODO: calcular média geral.
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                //chamada do menu
                opcaoUser = Menu().ToUpper();

                
            }


        }
    }
}
