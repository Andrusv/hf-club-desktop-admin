using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.objects;
using DataAccess;
using Newtonsoft.Json;

namespace Domain
{
    public abstract class FileSystem
    {
        public static LoginInfo getJwt()
        {
            LoginInfo loginInfo = JsonConvert.DeserializeObject<LoginInfo>(Streams.read());
            return loginInfo;
        }

        public static String writeJwt(LoginInfo data)
        {
            String result = Streams.write(JsonConvert.SerializeObject(data));
            return result;
        }
    }
}
