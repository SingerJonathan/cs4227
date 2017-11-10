using System;
using System.Linq;
using System.Windows.Forms;

namespace cs4227.User
{
    public class RealAuthenticator : IAuthenticator
    {
        private string _authenticationCode;

        public void SendAuthenticationCode(string email)
        {
            var random = new Random();
            _authenticationCode = new string(Enumerable.Repeat("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", 5)
                .Select(s => s[random.Next(s.Length)]).ToArray());

            Console.WriteLine($@"Authentication Code ""{_authenticationCode}"" generated and sent to {email}");
            MessageBox.Show($@"You're Tap and Eat authentication code is: {_authenticationCode}",
                $@"New mail to {email} from noreplies@tapneat.com");
        }

        public bool VerifyAuthenticationCode(string code)
        {
            Console.WriteLine(
                $@"Authentication Code ""{_authenticationCode}"" verified as {_authenticationCode.Equals(code)}");
            return _authenticationCode.Equals(code);
        }
    }
}