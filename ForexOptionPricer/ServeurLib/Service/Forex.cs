using System.Collections.Generic;

namespace ServeurLib
{
    public class Forex : IForex
    {
        public void nouvelleOption(Option option, Dictionary<int,Option> tableau) 
        { tableau.Add(option.NumberId,option); }


        public void changeType(string type, int numberId, Dictionary<int, Option> tableau) 
        { tableau[numberId].TypeOption = type; }
        public void changePaire(string paire, int numberId, Dictionary<int, Option> tableau)
        { tableau[numberId].CcyPair = paire; }
        public void changeMaturite(string maturite, int numberId, Dictionary<int, Option> tableau)
        { tableau[numberId].Maturity = maturite; }
        public void changeStrike(decimal strike, int numberId, Dictionary<int, Option> tableau)
        { tableau[numberId].Strike = strike; }


        public void supprimerOption(int numberId, Dictionary<int, Option> tableau) 
        { tableau.Remove(numberId); }
    }
}
