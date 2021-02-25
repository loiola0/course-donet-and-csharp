using System;

namespace Teste
{
    class App
    {
        static void Main(string[] args){

            ColecaoPessoa p = ColecaoPessoa.GetInstance();

            ColecaoPessoa p2 = ColecaoPessoa.GetInstance();

            PessoaFisica f = new PessoaFisica();
            f.setNome("Victor");
            f.setCpf("12345678900000");

            PessoaJuridica j = new PessoaJuridica();
            j.setNome("Victor");
            j.setCnpj("12345678900000");

            p.inserir(f);
            p.inserir(j);

            p.imprimirDadosColecao();

            //verification if instances are equals
            if(p == p2){
                Console.WriteLine("Instances ares equals!");
            }else{
                Console.WriteLine("Instances not ares equals!");
            }
            
        }
    }
}
