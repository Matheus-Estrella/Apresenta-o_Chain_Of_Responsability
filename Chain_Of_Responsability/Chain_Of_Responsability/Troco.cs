using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_Of_Responsability
{
    public abstract class Troco
    {
        protected Troco _troco;
        public void Prox(Troco troco)
        {
            _troco = troco;
        }
        public abstract float LiberarTroco(float extrato);
    }
}
