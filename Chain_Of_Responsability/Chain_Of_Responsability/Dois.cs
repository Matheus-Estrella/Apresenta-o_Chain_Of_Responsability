using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_Of_Responsability
{
    internal class Dois : Troco
    {
        private float valor_moeda = 2;
        private int qnt;

        public Dois(int qnt)
        {
            this.qnt = qnt;
        }

        public override float LiberarTroco(float extrato)
        {
            int _qnt = qnt;
            int counter = 0;
            while (_qnt != 0)
            {
                if (extrato >= valor_moeda)
                {
                    counter++;
                    extrato -= valor_moeda;
                }
                if (extrato < valor_moeda)
                {
                    Console.WriteLine($"\nSaldo insuficiente para o valor da transação [ {extrato:0.00} reais ]");
                    break;
                }
                _qnt--;
            }
            Console.WriteLine($"\nSacadas {qnt - _qnt} notas de {valor_moeda:0.00} reais");
            return extrato;
        }
    }
}
