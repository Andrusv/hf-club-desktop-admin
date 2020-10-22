using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.objects
{
    public class LoginResponse:Stats
    {
        public String token;
        public String error;
    }

    public class Stats
    {
        public Double totalCredits;
        public int totalWithdrawals;
        public int totalCoupons;
    }
}
