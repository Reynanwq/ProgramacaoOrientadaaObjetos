using System;

namespace Abstracao
{
    class PessoaFisica : Padrao
    {
        public override void taxaEmprestimo(double valor)
        {
            Console.WriteLine("taxa de emprestimo para Pessoa Fisica R$ " + (valor * 0.1));
        }
    }
}