using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatEngine.Model
{
    class LoginInfo
    {
        public bool IsAuthorized { get; set; }
        public string ErroReason { get; set; }
        public int? ErrorType { get; set; }
        public long? UserId { get; set; }
        public string SessionToken { get; set; }
    }
}
