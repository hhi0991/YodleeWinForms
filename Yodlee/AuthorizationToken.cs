using System;
using System.Collections.Generic;
using System.Text;

namespace Yodlee
{
    public class Token
    {
        public string accessToken { get; set; }
        public DateTime issuedAt { get; set; }
        public int expiresIn { get; set; }
    }

    public class AuthorizationToken
    {
        public Token token { get; set; }
    }
}
