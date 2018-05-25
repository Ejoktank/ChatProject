using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ChatEngine.Model
{
    [DataContract]
    public class RegistrationInfo
    {
        [DataMember]
        public bool IsRegistred { get; set; }
        [DataMember]
        public string ErrorReason { get; set; }
    }
}
