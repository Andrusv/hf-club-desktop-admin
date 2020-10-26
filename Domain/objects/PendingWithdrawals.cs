using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.objects
{
    public class PendingWithdrawals
    {
        public PendingWithdrawalsObject[] pendingWithdrawals;
    }

    public class PendingWithdrawalsObject
    {
        public String user_id;
        public Double balance;
    }
}
