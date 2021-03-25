namespace AbstractFactory.AbstractClasses
{
    public abstract class MensagemLogout
    {  
        //atrributes
        private string logo {get;set;}
        private string mensagem {get;set;}

        //constructs
        public MensagemLogout(){}
        public MensagemLogout(string logo,string mensagem){
            this.logo = logo;
            this.mensagem = mensagem;
        }

        //methods

        public abstract void MostrarTelaGrafica();
        

    }
}