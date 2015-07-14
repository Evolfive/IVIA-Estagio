using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IVIA.Estagio.ATM
{
    public class CargaAtm
    {
        Atm _atm;
        public CargaAtm(Atm atm)
        {
            _atm = atm;
        }
        public void Adicionar(int qtdeNotas, ValorNota valorNota)
        {
            _atm.TotalEmDinheiro += (qtdeNotas * (int)valorNota);
        }
    }
}
