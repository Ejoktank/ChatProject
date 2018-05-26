using ChatEngine.Model;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Net;
using System.Text;
using System;

namespace ChatEngine.Service
{
    public class RequestService : BaseService
    {

        public RegistrationInfo Registration(RegistrationRequest request)
        {
            try
            {
                return (RegistrationInfo)ServerRequest<RegistrationInfo>("Register", request); ;
            }
            catch(Exception ex) { return new RegistrationInfo() { IsRegistred = false, ErrorReason = "Request error" }; }
        }
    }
}
