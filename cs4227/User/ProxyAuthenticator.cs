using System;

namespace cs4227.User
{
    public class ProxyAuthenticator : IAuthenticator
    {
        private readonly RealAuthenticator _realAuthenticator;

        public ProxyAuthenticator()
        {
            _realAuthenticator = new RealAuthenticator();
            Console.WriteLine(@"New RealAuthenticator assigned to ProxyAuthenticator");
        }

        public void SendAuthenticationCode(string email)
        {
            _realAuthenticator.SendAuthenticationCode(email);
        }

        public bool VerifyAuthenticationCode(string code)
        {
            return _realAuthenticator.VerifyAuthenticationCode(code);
        }
    }
}