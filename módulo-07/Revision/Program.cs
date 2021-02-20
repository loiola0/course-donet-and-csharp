using System;

namespace Revision
{
    class Program
    {

        static string Menu(){
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

            while(opcaoUser.ToUpper() != "X"){
                switch(opcaoUser){
                    case "1":
                        //TODO: adicionar aluno.
                        break;
                    case "2":
                        //TODO: listar alunos.
                        break;
                    case "3":
                        //TODO: calcular média geral.
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                //chamada do menu
                opcaoUser = Menu();

                
            }


        }
    }
}
