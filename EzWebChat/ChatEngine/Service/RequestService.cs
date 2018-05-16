using ChatEngine.Model;
using System.IO;
using System.Runtime.Serialization.Json;

namespace ChatEngine.Service
{
    public class RequestService
    {
        public bool Registration(RegistrationRequest request)
        {
            DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(RegistrationRequest));
            try
            {
                using (FileStream fs = new FileStream("test.json", FileMode.OpenOrCreate))
                {
                    json.WriteObject(fs, request);
                }

                return true;
            }
            catch { return false; }
        }
    }
}
