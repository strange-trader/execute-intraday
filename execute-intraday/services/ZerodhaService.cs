using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KiteConnect;

namespace execute_intraday.services
{
    public interface IZerodhaService
    {
        public string zerodhatrying();
    }
    public class ZerodhaService: IZerodhaService
    {
        public string zerodhatrying()
        {
            Kite kite = new Kite("c6gvjoa4u1xwkt45", Debug: true);
            kite.GetLoginURL();
            
            kite.SetAccessToken("rEK7IQE29rwzY3wiFLh16A1O6cFRT6Pi");
            kite.SetSessionExpiryHook(() => Console.WriteLine("need to login agian"));

            Dictionary<string, dynamic> response = kite.PlaceOrder(
                Exchange: Constants.EXCHANGE_NSE,
                TradingSymbol: "",
                TransactionType: Constants.TRANSACTION_TYPE_BUY,
                Quantity: 1,
                Price: 64.0000m,
                OrderType: Constants.ORDER_TYPE_SL,
                Product: Constants.PRODUCT_MIS
            );


            List<Holding> holdings = kite.GetHoldings();
            Console.WriteLine(holdings[0].AveragePrice);
            return "trying it out";
        }
    }
}
