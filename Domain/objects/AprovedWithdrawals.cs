using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.objects
{
    public class AprovedWithdrawals
    {
        public AprovedWithdrawalsObject[] aprovedWithdrawals;
    }

    public class AprovedWithdrawalsObject
    {
        public String withdrawal_id;
        public String user_id;
        public Double balance;
        public String characterName;
    }
}
