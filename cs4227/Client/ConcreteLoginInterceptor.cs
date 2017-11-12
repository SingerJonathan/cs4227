using System;
using System.IO;
using cs4227.UI;
using cs4227.Meal;

namespace cs4227.Client
{
    internal class ConcreteLoginInterceptor : Interceptor
    {
        public void LoginRegister(LoginMenuV2 reference)
        {
            //Console.WriteLine(Environment.CurrentDirectory);
            var UsernameContext = new ContextObject();
            var Username = UsernameContext.LoginContext(reference);
            var FileName = "logins.txt";
            var LoginTime = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss.ffff");
            try
            {
                if (!File.Exists(FileName))
                {
                    File.Create(FileName).Close();
                    TextWriter tw = new StreamWriter(FileName);
                    tw.WriteLine(Username + ", " + LoginTime);
                    tw.Close();
                }
                else
                {
                    TextWriter tw = new StreamWriter(FileName, true);
                    tw.WriteLine(Username + ", " + LoginTime);
                    tw.Close();
                }
                Console.WriteLine(@"Interceptor for logging logins invoked");
            }
            catch (IOException e)
            {
                throw e;
            }
        }

        public void OrderLog()
        {
        }
    }
}