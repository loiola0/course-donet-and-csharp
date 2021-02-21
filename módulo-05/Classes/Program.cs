using System;

namespace Classes.Herança
{
    class Program
    {
        static void Main(string[] args)
        {
            Ponto p1 = new Ponto(10,20);

            Ponto3d p2 = new Ponto3d(10,20,30);

            
            Ponto3d.Calcular();


        }
    }
}
