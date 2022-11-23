using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace ServeurLib
{
    [DataContract]
    public class Option
    {
        public int NumberId { get; }
        public string TypeOption { get; set; }
        public string CcyPair { get; set; }
        public string Maturity { get; set; }
        public decimal Strike { get; set; }

        public Option(int numberId, string typeOption, string ccyPair, string maturity, decimal strike)
        {
            NumberId = numberId;
            TypeOption = typeOption;
            CcyPair = ccyPair;
            Maturity = maturity;
            Strike = strike;
        }
    }
}
