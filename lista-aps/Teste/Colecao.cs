namespace Teste{
    public interface Colecao{
        //methods
        bool inserir(Pessoa p);
        bool remover();

        bool remover(int indice);
        void atualizar(int indice, Pessoa p);
        bool pesquisar(Pessoa p);
        bool colecaoEstaVazia();
        void imprimirDadosColecao();
        Pessoa retornarObjeto(int indice);
    }
}