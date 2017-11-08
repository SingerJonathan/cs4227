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
            Random random = new Random();
            _authenticationCode = new string(Enumerable.Repeat("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", 5).Select(s => s[random.Next(s.Length)]).ToArray());

            MessageBox.Show($"You're Tap and Eat authentication code is: {_authenticationCode}", $"New mail to {email} from noreplies@tapneat.com");
        }

        public bool VerifyAuthenticationCode(string code)
        {
            return _authenticationCode.Equals(code);
        }
    }
}
