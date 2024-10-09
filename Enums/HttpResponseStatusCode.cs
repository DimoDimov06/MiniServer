using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniServer.HTTP.Enums
{
    public enum HttpResponseStatusCode
    {
        OK = 200,
        Created = 201,
        Found = 302,
        SeeOther = 303,
        BadReaquest = 400,
        Unauthorized = 403,
        NotFound = 404,
        InternalServerError = 500
    }
}
