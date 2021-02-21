namespace Classes.Herança
{
    public class Ponto3d : Ponto
    {

        public int z;

        public Ponto3d (int x, int y,int z) :base(x,y){
            this.z = z;
            calcularDistancia();
        }

        public static void Calcular(){

        }

        public override void calcularDistancia3(){
            
        }



    }
}