using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Stream_IO.Services
{
    internal class currencyService : IDisposable
    {
        private readonly HttpClient httpClient;
        private bool _dispose = false;
        public currencyService()
        {
            httpClient = new HttpClient();
        }

        public void Dispose()
        {
            //To Clear Managament and un management code or resources 
             Dispose(true);
        }
        /// <summary>
        /// If Disposing is equal true clean management and unmanagement code
        /// If Disposing is equal false clean unmanagement code and large fields
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
            if (_dispose == false) return;

            //Implement Dispose Logic
            _dispose = true;
            if (disposing)
            {
                //dispose manage resources
                httpClient.Dispose();
            }

            
        }

        public string getCurrencies()
        {
            string url = "https://www.coinbase.com/api/v2/currencies";
            var result = httpClient.GetStringAsync(url).Result;
            return result;

        }
    }
}
