using System.Collections.Generic;
using System.ServiceModel;

namespace ServeurLib
{
    [ServiceContract]
    public interface IForex
    {
        [OperationContract]
        void nouvelleOption(Option option, Dictionary<int, Option> tableau);


        [OperationContract]
        void changeType(string type, int numberId, Dictionary<int, Option> tableau);

        [OperationContract]
        void changePaire(string paire, int numberId, Dictionary<int, Option> tableau);

        [OperationContract]
        void changeMaturite(string maturite, int numberId, Dictionary<int, Option> tableau);

        [OperationContract]
        void changeStrike(decimal strike, int numberId, Dictionary<int, Option> tableau);


        [OperationContract]
        void supprimerOption(int numberId, Dictionary<int, Option> tableau);
    }
}
