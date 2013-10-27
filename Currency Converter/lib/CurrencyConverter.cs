using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;

namespace Currency_Converter
{
    class CurrencyConverter
    {
        public float inputMoney;
        public string inputCurrency;
        public string outputCurrency;

        public string convert()
        {
            //Get current conversion rate from API
            string apikey = "20554f2e3dfd0a6950cd5a7661bd54d4baec31ac";
            string callURL = "http://currency-api.appspot.com/api/" + inputCurrency + "/" + outputCurrency + ".json?key=" + apikey;

            WebClient w = new WebClient();
            string response;

            try
            {
               response = w.DownloadString(callURL);
            }
            catch
            {
                throw new Exception("Could not retrieve rate from API. ");
            }


            Rate ro = JsonConvert.DeserializeObject<Rate>(response);

            float r = Convert.ToSingle(ro.rate);

            //Do the math
            string o = (inputMoney * r).ToString("n2");
            return o;
        }
    }
}
