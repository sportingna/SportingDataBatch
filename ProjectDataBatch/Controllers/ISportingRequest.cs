using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDataBatch.Controllers
{
    interface ISportingRequest
    {
        bool Run(URLModel urlRequest);
    }
    
}
