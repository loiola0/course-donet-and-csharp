using System;

namespace Teste{

    public class PessoaFisica : Pessoa{

        //attributes
        private string cpf;
        private DateTime dataCriacao = new DateTime().Date;

        public void setCpf(string cpf){
            this.cpf = cpf;
        }
        public string getCpf(){
            return this.cpf;
        }

        public void setDataCriacao(DateTime dataCriacao){
            this.dataCriacao = dataCriacao;
        }
        public DateTime getCriacao(){
            return this.dataCriacao;
        }

        public override bool validarDocumento(){
            if(this.cpf.Length == 14)
                return true;
            return false;
        }

        public override int calcularIdade(){
            //search current date and convert in string after in a integer
            var dateCurrent =  int.Parse(DateTime.Now.Year.ToString());

            int date = int.Parse(this.dataCriacao.Year.ToString());

            return dateCurrent - date;
            
        }

        public string toString(){
            return "";
        }
        public bool equals(string cpf1, string cpf2){
            if(cpf1 == cpf2){
                return true;
            }
            
            return false;
        }


    }
    
}