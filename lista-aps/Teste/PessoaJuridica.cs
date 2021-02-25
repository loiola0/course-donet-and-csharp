using System;
namespace Teste{
    public class PessoaJuridica : Pessoa{


        //attributes
        private string cnpj;
        private DateTime dataCriacao = new DateTime().Date;
        
        public void setCnpj(string cnpj){
            this.cnpj = cnpj;
        }
        public string getCnpj(){
            return this.cnpj;
        }

        public void setDataCriacao(DateTime dataCriacao){
            this.dataCriacao = dataCriacao;
        }
        public DateTime getCriacao(){
            return this.dataCriacao;
        }

        public override bool validarDocumento(){
            if(this.cnpj.Length == 18)
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
        public bool equals(string cnpj1, string cnpj2){
            if(cnpj1 == cnpj2){
                return true;
            }
            
            return false;
        }

        

        
    }
}