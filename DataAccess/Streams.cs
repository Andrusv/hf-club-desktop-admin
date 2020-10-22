using System;
using System.IO;
using System.Text;

namespace DataAccess
{
    public abstract class Streams
    {
        static readonly String fileName = @".\cache";

        public static String read()
        {
            try
            {
                String data = "";

                FileStream fs = File.OpenRead(fileName);

                byte[] buf = new byte[1024];
                int c;

                while ((c = fs.Read(buf, 0, buf.Length)) > 0)
                {
                    data = data + Encoding.UTF8.GetString(buf, 0, c);
                }

                fs.Close();
                return data;
            } catch (Exception ex)
            {
                return "{\"error\":\""+ex.ToString()+"\"";
            }
        }

        public static String write(String data)
        {
            try
            {
                FileStream fs = File.OpenWrite(fileName);
                
                byte[] bytes = Encoding.UTF8.GetBytes(data);

                fs.Write(bytes, 0, bytes.Length);

                fs.Close();
                return "Writen success!";
            } catch (Exception ex)
            {
                return ex.ToString();
            }
            
        }
    }
}
