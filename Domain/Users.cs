using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using RestSharp;

namespace Domain
{
    public class Users:Api
    {
        public string username;
        public string password;

        public async Task<String> getAResponseAsync(String body)
        {
            return await simpleRequest("/weso/weso",body,HttpMethod.Get, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiI1ZjgxMzFhZjI2ODFmZTE4ZmM0OWZlN2QiLCJjaGFyYWN0ZXJfbmFtZSI6Ii4tUGVyc2VvNCIsImVtYWlsIjoicGVyc2VvMTBAZ21haWwuY29tIiwic2NvcGVzIjpbInNpZ25pbjphdXRoIiwic2lnbnVwOmF1dGgiLCJyZWFkOnVzZXJzIiwidXBkYXRlOnVzZXJzIiwicmVhZDp3aXRoZHJhd2FscyIsImNyZWF0ZTp3aXRoZHJhd2FscyIsInJlYWQ6Y29kZXMiXSwiaWF0IjoxNjAzMTY4NDEwLCJleHAiOjE2MDMyNTQ4MTB9.uNVtcrTrjT6pPVV3Kk8WHk066tB8rJxKvR7ienvq17Q");
        }
    }
}
