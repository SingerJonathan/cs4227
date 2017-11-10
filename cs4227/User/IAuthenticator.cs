namespace cs4227.User
{
    public interface IAuthenticator
    {
        void SendAuthenticationCode(string email);
        bool VerifyAuthenticationCode(string code);
    }
}