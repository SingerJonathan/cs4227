using cs4227.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs4227.Interceptor.ConcreteInterceptor
{
    class ConcreteLoginInterceptor : Interceptor
    {

        public void LoginRegister(LoginMenuV2 reference)
        {
            //Console.WriteLine(Environment.CurrentDirectory);
            ContextObject UsernameContext = new ContextObject();
            string Username = UsernameContext.LoginContext(reference);
            string FileName = "logins.txt";
            string LoginTime = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss.ffff");
            try
            {
                if(!(File.Exists(FileName)))
                {
                    File.Create(FileName).Close();
                    TextWriter tw = new StreamWriter(FileName);
                    tw.WriteLine(Username + ", "+LoginTime);
                    tw.Close();
                }
                else
                {
                    TextWriter tw = new StreamWriter(FileName, true);
                    tw.WriteLine(Username + ", "+LoginTime);
                    tw.Close();
                }
                Console.WriteLine("Interceptor for logging logins invoked");
            }
            catch (IOException e) { }
        }

        public void OrderLog() { }
    }
}
