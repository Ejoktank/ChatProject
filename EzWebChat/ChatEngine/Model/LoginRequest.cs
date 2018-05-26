using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatEngine.Model
{
    public class LoginRequest
    {
        public string Login { get; set; }
        public string PasswordHash { get; set; }
        public DateTime LoginTime { get; set; }
        public string HashSubcribe { get; set; }
    }
}
