using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DBST.Hospital.Scheme
{
    public class ResponseScheme
    {
        public HttpStatusCode StatusCode {get; set;}
        public string Message { get; set;}
        public dynamic Data { get; set;}
    }
}
