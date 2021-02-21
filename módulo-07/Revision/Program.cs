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
                        decimal notaTotal = 0;
                        var nrAlunos = 0;

                            for (int i = 0; i<alunos.Length; i++){
                                    
                                    if(!string.IsNullOrEmpty(alunos[i].Nome)){
                                        notaTotal+=alunos[i].Nota;
                                        nrAlunos++;
                                    }
                                
                            }
                            var mediaGeral = notaTotal/nrAlunos;
                        
                            Conceito geral;
                                if(mediaGeral<2){
                                    geral = Conceito.E;
                                }
                                else if(mediaGeral < 4){
                                    geral = Conceito.D;
                                }
                                else if(mediaGeral < 6){
                                    geral = Conceito.C;
                                }
                                else if(mediaGeral < 8){
                                    geral = Conceito.B;
                                }
                                else{
                                    geral = Conceito.A;
                                }
                            Console.WriteLine($"Média Geral: {mediaGeral} - Conceito: {geral}");

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
