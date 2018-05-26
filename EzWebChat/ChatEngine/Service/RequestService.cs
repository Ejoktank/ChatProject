using ChatEngine.Model;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Net;
using System.Text;
using System;
using System.Threading.Tasks;

namespace ChatEngine.Service
{
    public class RequestService : BaseService
    {

        async public Task<RegistrationInfo> Registration(RegistrationRequest request)
        {
            try
            {
                return (RegistrationInfo)(await ServerRequest<RegistrationInfo>("Register", request)); ;
            }
            catch(Exception ex) { return new RegistrationInfo() { IsRegistred = false, ErrorReason = "Request error" }; }
        }
    }
}
