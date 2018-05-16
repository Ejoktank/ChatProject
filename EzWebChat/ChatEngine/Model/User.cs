using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatEngine.Model
{
    class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long UserId { get; set; }
        public string UserName { get; set; }
        public bool Online { set; get; }
    }
}
