using ProjectDataBatch.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDataBatch.Controllers
{
    class SportingRequest : ISportingRequest
    {

        public bool Run(URLModel urlReqest)
        {
            MakeRequestAsync(urlReqest);
            return true;
        }

       private async Task MakeRequestAsync(URLModel urlReqest)
        {
            var client = new HttpClient();

            // Request headers
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", SportAPIUtil.SubscriptionKey);

            

            var uri = String.Format(urlReqest.URL);

            var response = await client.GetAsync(uri);
        }
    }
}

