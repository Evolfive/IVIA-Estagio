using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IVIA.Estagio.ATM
{
    public class Atm
    {

       
        public Atm()
        {
            NotasDisponiveis = new Dictionary<ValorNota, int>();
            NotasDisponiveis.Add(ValorNota.Cem, 0);
            NotasDisponiveis.Add(ValorNota.Cinquenta, 0);
            NotasDisponiveis.Add(ValorNota.Vinte, 0);
            NotasDisponiveis.Add(ValorNota.Dez, 0);
            NotasDisponiveis.Add(ValorNota.Cinco, 0);
            NotasDisponiveis.Add(ValorNota.Dois, 0);
        }
        public int TotalEmDinheiro { get; internal set; }

        public Dictionary<ValorNota, int> NotasDisponiveis { get; internal set; }

        public bool Sacar(int saque)
        {
            if (TotalEmDinheiro == 0)
                return false;

            return true;
        }
    }
}
