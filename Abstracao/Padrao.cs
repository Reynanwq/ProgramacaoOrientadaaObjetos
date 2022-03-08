using System;

namespace Abstracao
{
    abstract class Padrao
    {
        //metodo obrigatorio
        public abstract void taxaEmprestimo(double valor);

        //metodo opcional
        public void calculoPoupanca(double valor, double taxa)
        {
            Console.WriteLine("Ganhos obtidos pela poupança R$ " + (valor * taxa));
        }  
    }
}