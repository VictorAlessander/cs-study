using System;
using Hello;

namespace hwapp{
    public class Program{
        public static HelloWorld boas_vindas;

        public static void Main(string[] args){
            
            boas_vindas = new Hello.HelloWorld();
            Console.WriteLine(boas_vindas.Bemvindo());
        }
    }
}