﻿using System;

namespace DigitalInnovationOne
{
    class Program
    {
        static void instrucaoDO(){
            string texto;
            do{
              texto = Console.ReadLine();
              Console.WriteLine(texto);  
            }while(!string.IsNullOrEmpty(texto));
        }
        static void Main(string[] args)
        {
        //   var s = new Pilha();
            
        //     //s.Empilhar(10);
        //     //s.Empilhar(12);
        //     //s.Empilhar(45);

        //     Console.WriteLine(s.Desempilhar());
        //     Console.WriteLine(s.Desempilhar());
        //     Console.WriteLine(s.Desempilhar());

        instrucaoDO();
        }
    }
}
