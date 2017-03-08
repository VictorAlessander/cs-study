using System;
using Hello;

namespace hwapp{
    public class Program{
        public static HelloWorld boas_vindas;
        public static HelloWorld calc;

        public static void Main(string[] args){
            
            boas_vindas = new Hello.HelloWorld();
            Console.WriteLine(boas_vindas.Bemvindo());
            
            calc = new Hello.HelloWorld();
            Console.WriteLine("Soma: {0}", calc.Soma(4, 6));
            Console.WriteLine("Subtração: {0}", calc.Subtracao(4, 6));
            Console.WriteLine("Multiplicação: {0}", calc.Multiplicacao(4, 6));
            Console.WriteLine("Divisão: {0}", calc.Divisao(4, 6));
        }
    }
}