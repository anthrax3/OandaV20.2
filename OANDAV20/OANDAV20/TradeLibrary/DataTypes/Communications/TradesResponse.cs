﻿using System.Collections.Generic;

namespace OANDAV20.REST20.TradeLibrary.DataTypes.Communications
{
   public class TradesResponse
   {
      public List<Trade.Trade> trades;
      public string lastTransactionID;
   }
}