using System;
using System.Collections;
namespace Teste{
    public class ColecaoPessoa : Colecao{
        //constructors
        
        private ColecaoPessoa(){}
        private static ColecaoPessoa _instance;

        //attributes
        private Pessoa[] dados = new Pessoa[100];
        private static int posicaoCorrente = 0;
        
        //methods
        public static ColecaoPessoa GetInstance()
        {
            if (_instance == null)
            {
                _instance = new ColecaoPessoa();
            }
            return _instance;
        }

         public bool inserir(Pessoa p){
            if(posicaoCorrente<100){
             this.dados[posicaoCorrente] = p;
             posicaoCorrente++;

             return true;
            }
            return false;
         }

         public bool remover(){
            if(posicaoCorrente >= 0 && posicaoCorrente < 100){
                if(dados[posicaoCorrente] != null){
                   dados[posicaoCorrente] = null ;
                   posicaoCorrente--;
                   return true;
                }
            }
                
             return false;
         }
         public bool remover(int indice){
            if(indice >= 0 && indice < 100){
                if(dados[indice] != null){
                   dados[indice] = null ;
                   posicaoCorrente--;
                   return true;
                }
            }
                
             return false;
         }
         public void atualizar(int indice,Pessoa p){
            if(indice >= 0 && indice < 100){
                if(dados[indice] != null){
                   dados[indice] = p ;
                }
            } 
         }
        public bool pesquisar(Pessoa p){
            bool rtrn = false;

                //search people
                for(int i = 0;i<100;i++){
                    if(dados[i].getNome() == p.getNome()){
                        rtrn = true;
                        break;
                    }
                }

            return rtrn;
        }
        public bool colecaoEstaVazia(){
            if(dados.Length == 0)
                return true;
            return false;
        }
        public void imprimirDadosColecao(){
        
            for(int i = 0;i<100;i++){
                 if(dados[i].GetType().Equals(PessoaFisica)){

                 }else{

                 }
            }
        
        }
        public Pessoa retornarObjeto(int indice){
            if(indice >= 0 && indice < 100){
                return dados[indice];
            }
            return null;
        }

    }
}