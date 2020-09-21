using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    class TextConnector : IDataConnection
    {
        public PrizeModel CreatePrize(PrizeModel model)
        {
            //TODO - Wire up create prize 
            model.id = 1;

            return model;

        }
    }
}
