namespace AbstractFactory.AbstractClasses
{
    public abstract class MensagemLogon
    {
        //attributes
        private string logo {get;set;}
        private string mensgagem {get;set;}

        //constructs
        public MensagemLogon(){}

        public MensagemLogon(string logo, string mensagem){
            this.logo = logo;
            this.mensgagem = mensagem;
        }

        //methods
        public void MostrarTelaGrafica(){}


        
    }
}