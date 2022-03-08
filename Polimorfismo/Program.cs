using System;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            //instaciar Estagiário
            Imposto objetoE = new Estagiario();
            objetoE.valeAlimentacao(1000);
            objetoE.valeTransporte(1000);
            Console.WriteLine("---------------");

            //instanciar Gerente
            Imposto objetoG = new Gerente();
            objetoG.valeAlimentacao(5000);
            objetoG.valeTransporte(5000);
            Console.WriteLine("---------------");

            //instaciar Atendente
            Imposto objetoA = new Atendente();
            objetoA.valeAlimentacao(2000);
            objetoA.valeTransporte(2000);
        }
    }
}