using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        //TODO - Make the CreatePrize method actually save to the db.
        /// <summary>
        /// Saves a new prize to the database
        /// </summary>
        /// <param name="model"> The prize information</param>
        /// <returns>The prize information, including the unique Id.</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.id = 1;
            return model;
        }
    }
}
