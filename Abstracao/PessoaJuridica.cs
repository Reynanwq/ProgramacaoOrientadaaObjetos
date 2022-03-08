using System;

namespace Abstracao
{
    class PessoaJuridica : Padrao
    {
        public override void taxaEmprestimo(double valor)
        {
            Console.WriteLine("taxa de emprestimo para Pessoa Juridica R$ " + (valor * 0.2));
        }
    }
}