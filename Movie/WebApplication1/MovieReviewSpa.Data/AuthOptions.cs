using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieReviewSpa.Data
{
    public class AuthOptions
    {
         public const string ISSUER = "MyAuthServer";
        public const string AUDIENCE = "http://localhost:4200/";
        const string KEY = "very_secretkey!123";
        public const int LIFETIME = 60;
        public static SymmetricSecurityKey GetSymmetricSecurityKey()
        {
            return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(KEY));
        }
    }
}
