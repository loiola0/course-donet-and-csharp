namespace AbstractFactory.AbstractClasses
{
    public abstract class FabricaAbstrata
    {
        //Methods
        public abstract MensagemLogon GerarTelaLogon();

        public abstract MensagemLogout GerarTelaLogout();
        
        public static FabricaAbstrata configurarIntancia(int codigoBanco){

        }

    }
}