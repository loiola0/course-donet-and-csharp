using System;
namespace Teste{

    abstract public class Pessoa{

        
        //attributes
        private string name;

        public string getNome(){
            return name;
        }
        public void setNome(string name){
            this.name = name;
        }

        //methods abstracts
        public abstract bool validarDocumento();
        public abstract int calcularIdade();
        
    }
}