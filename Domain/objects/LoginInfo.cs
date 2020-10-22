using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.objects
{
    public class LoginInfo
    {
        public String jwt;
        public DateTime sessionExpire;
        public String error;
    }
}
